export class Person{
    constructor(
        public id:string,
        public firstName:string,
        public lastName:string,
        public email:string,
        public phone:string,
        public personTypeId:string
    ){}
}

export class PersonType{
    constructor(
        public id:string,
        public description:string,
    ){}
}