ALTER TABLE Person                                           -- FK table name
ADD CONSTRAINT fk_PersonType_Person                          -- friendly name
FOREIGN KEY (PersonTypeId)                                   -- FK table field name
REFERENCES PersonType(Id)                                    -- PK table name (PK id field name)