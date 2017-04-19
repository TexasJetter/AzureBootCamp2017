import { AzurePeoplePage } from './app.po';

describe('azure-people App', () => {
  let page: AzurePeoplePage;

  beforeEach(() => {
    page = new AzurePeoplePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('ap works!');
  });
});
