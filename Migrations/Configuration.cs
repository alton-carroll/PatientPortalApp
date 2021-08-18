namespace PatientPortalApp.Migrations
    {
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PatientPortalApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PatientPortalApp.Data.PatientPortalAppContext>
        {
        public Configuration()
            {
            AutomaticMigrationsEnabled = false;
            }

        protected override void Seed(PatientPortalApp.Data.PatientPortalAppContext context)
            {
            var patients = new List<Patient>
                {
                new Patient
                        {
                        FirstName = "Myron",
                        LastName = "Waelchi",
                        BirthDate = DateTime.Parse("2004-5-8"),
                        Ssn = "999-32-2576",
                        ActivePatient = true,
                        Street = "703 Schoen Extension",
                        City = "Townsend",
                        State = "Massachusetts",
                        Zip = "1469",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "c9b5fda8-649e-47f4",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-1-9"),
                        CreatedBy = "Rolfson, Sharmaine",
                        Modified = DateTime.Parse("2019-3-22"),
                        ModifiedBy = "Paredes, Ana"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Rich",
                        LastName = "Harber",
                        BirthDate = DateTime.Parse("1967-8-26"),
                        Ssn = "999-94-2750",
                        ActivePatient = true,
                        Street = "180 Zemlak Harbor Apt 42",
                        City = "Marshfield",
                        State = "Massachusetts",
                        Zip = "2050",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "3c2eab1b-667c-44d2",
                        SecondaryInsurance = "Cigna Health",
                        SecondaryInsuranceID = "8e63-3c41ec3d5b2b",
                        Created = DateTime.Parse("2019-1-14"),
                        CreatedBy = "Kulas, Asha",
                        Modified = DateTime.Parse("2019-2-20"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Leana",
                        LastName = "Bernier",
                        BirthDate = DateTime.Parse("1998-7-9"),
                        Ssn = "999-71-6789",
                        ActivePatient = true,
                        Street = "272 Bradtke Vale",
                        City = "Plymouth",
                        State = "Massachusetts",
                        Zip = "2360",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "ba3fcb7a-6d12-4f97",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "9358-5cdba21d15d3",
                        Created = DateTime.Parse("2019-1-22"),
                        CreatedBy = "Goyette, Anissa",
                        Modified = DateTime.Parse("2019-3-12"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        FirstName = "Tynisha",
                        LastName = "McGlynn",
                        BirthDate = DateTime.Parse("2010-5-29"),
                        Ssn = "999-67-7220",
                        ActivePatient = true,
                        Street = "620 Vandervort Throughway Apt 23",
                        City = "Everett",
                        State = "Massachusetts",
                        Zip = "2148",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "8f01ac50-19c7-4a30",
                        SecondaryInsurance = "Humana",
                        SecondaryInsuranceID = "b260-b7a5b725f582",
                        Created = DateTime.Parse("2019-1-22"),
                        CreatedBy = "McLaughlin, Angle",
                        Modified = DateTime.Parse("2019-4-2"),
                        ModifiedBy = "Watsica, Lory"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Williams",
                        LastName = "Legros",
                        BirthDate = DateTime.Parse("1968-1-2"),
                        Ssn = "999-18-8582",
                        ActivePatient = true,
                        Street = "581 Simonis Estate Apt 45",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "a0667059-5b72-4c8e",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-2-18"),
                        CreatedBy = "Sawayn, Luna",
                        Modified = DateTime.Parse("2019-4-22"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Floy",
                        LastName = "West",
                        BirthDate = DateTime.Parse("1983-1-29"),
                        Ssn = "999-19-5912",
                        ActivePatient = true,
                        Street = "1052 Barrows Union",
                        City = "Brookline",
                        State = "Massachusetts",
                        Zip = "2215",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "910da454-49f1-4828",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b856-995979c53f8c",
                        Created = DateTime.Parse("2019-2-27"),
                        CreatedBy = "DuBuque, Norris",
                        Modified = DateTime.Parse("2019-3-31"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Leroy",
                        LastName = "Heathcote",
                        BirthDate = DateTime.Parse("1991-11-22"),
                        Ssn = "999-17-1098",
                        ActivePatient = true,
                        Street = "192 Erdman Camp",
                        City = "Southborough",
                        State = "Massachusetts",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "5620b276-5302-4cba",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "81cc-d570c676958b",
                        Created = DateTime.Parse("2019-3-1"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2019-4-23"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        FirstName = "Eusebio",
                        LastName = "Purdy",
                        BirthDate = DateTime.Parse("2018-3-10"),
                        Ssn = "999-19-5498",
                        ActivePatient = false,
                        Street = "844 Ferry Pathway Unit 18",
                        City = "Plymouth",
                        State = "Massachusetts",
                        Zip = "2360",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-3-10"),
                        CreatedBy = "Friesen, Mariano",
                        Modified = DateTime.Parse("2019-5-27"),
                        ModifiedBy = "Friesen, Mariano"
                        },
                    new Patient
                        {
                        FirstName = "Geraldo",
                        LastName = "Reilly",
                        BirthDate = DateTime.Parse("2006-10-8"),
                        Ssn = "999-48-9913",
                        ActivePatient = true,
                        Street = "1050 Bradtke Corner",
                        City = "Springfield",
                        State = "Massachusetts",
                        Zip = "1013",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "858c9853-013a-40d1",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "9ed7-66b66b0b4c5c",
                        Created = DateTime.Parse("2019-3-13"),
                        CreatedBy = "Friesen, Mariano",
                        Modified = DateTime.Parse("2019-5-21"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Kermit",
                        LastName = "Bogan",
                        BirthDate = DateTime.Parse("1970-3-8"),
                        Ssn = "999-75-1406",
                        ActivePatient = true,
                        Street = "574 Rogahn Key",
                        City = "Rochester",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "164d38cf-ffa2-4cb9",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-3-13"),
                        CreatedBy = "Rau, Tereasa",
                        Modified = DateTime.Parse("2019-6-3"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        FirstName = "Jorge Luis",
                        LastName = "Alva",
                        BirthDate = DateTime.Parse("2004-11-9"),
                        Ssn = "999-69-1233",
                        ActivePatient = true,
                        Street = "578 King Run Unit 88",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "976bcab3-c1c3-4141",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b6ca-e7dc1d365abb",
                        Created = DateTime.Parse("2019-3-17"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2019-6-6"),
                        ModifiedBy = "Zboncak, Shavonne"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Georgia",
                        LastName = "Pollich",
                        BirthDate = DateTime.Parse("1941-4-6"),
                        Ssn = "999-67-3780",
                        ActivePatient = true,
                        Street = "164 Larson Lane",
                        City = "Mattapoisett",
                        State = "Massachusetts",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "e11417ff-9331-4557",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "827a-6b608cba70b0",
                        Created = DateTime.Parse("2019-3-25"),
                        CreatedBy = "Berge, Ranae",
                        Modified = DateTime.Parse("2019-5-2"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Melodi",
                        LastName = "Howell",
                        BirthDate = DateTime.Parse("1957-10-11"),
                        Ssn = "999-16-7505",
                        ActivePatient = true,
                        Street = "235 Klocko Vista Suite 76",
                        City = "Marlborough",
                        State = "Massachusetts",
                        Zip = "1752",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "34068b8e-9f6f-4f09",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b973-b64d194a1cd2",
                        Created = DateTime.Parse("2019-4-13"),
                        CreatedBy = "Friesen, Mariano",
                        Modified = DateTime.Parse("2019-6-21"),
                        ModifiedBy = "Mills, Nigel"
                        },
                    new Patient
                        {
                        FirstName = "Manuel",
                        LastName = "Luettgen",
                        BirthDate = DateTime.Parse("2005-8-8"),
                        Ssn = "999-53-5336",
                        ActivePatient = true,
                        Street = "769 Corwin Ferry Unit 49",
                        City = "Provincetown",
                        State = "Massachusetts",
                        Zip = "2657",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "a0a2069d-3abe-4591",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-4-26"),
                        CreatedBy = "Corwin, Shelly",
                        Modified = DateTime.Parse("2019-7-7"),
                        ModifiedBy = "Emard, Denisse"
                        },
                    new Patient
                        {
                        FirstName = "Brigitte",
                        LastName = "Jaskolski",
                        BirthDate = DateTime.Parse("2003-5-1"),
                        Ssn = "999-25-1773",
                        ActivePatient = true,
                        Street = "500 Cremin Well Apt 31",
                        City = "Chelsea",
                        State = "Massachusetts",
                        Zip = "2149",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "2e80ccff-35b3-47b7",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b19f-bce12b7e260e",
                        Created = DateTime.Parse("2019-5-1"),
                        CreatedBy = "Kulas, Asha",
                        Modified = DateTime.Parse("2019-7-1"),
                        ModifiedBy = "Ondricka, Bradley"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Kimiko",
                        LastName = "Turcotte",
                        BirthDate = DateTime.Parse("1988-3-12"),
                        Ssn = "999-17-9544",
                        ActivePatient = true,
                        Street = "805 Parker Ferry Apt 97",
                        City = "Shirley",
                        State = "Massachusetts",
                        Zip = "1464",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "aed1cc9f-5379-4277",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "b232-12593740db53",
                        CurrentBalance = 95.1M,
                        Created = DateTime.Parse("2019-5-3"),
                        CreatedBy = "Romaguera, Reggie",
                        Modified = DateTime.Parse("2019-7-15"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Tommy",
                        LastName = "Friesen",
                        BirthDate = DateTime.Parse("1989-10-13"),
                        Ssn = "999-63-4662",
                        ActivePatient = true,
                        Street = "301 Nicolas Route",
                        City = "Swampscott",
                        State = "Massachusetts",
                        Zip = "1907",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "013908ef-c887-4972",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-5-3"),
                        CreatedBy = "DuBuque, Norris",
                        Modified = DateTime.Parse("2019-7-23"),
                        ModifiedBy = "Emard, Denisse"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Elizabet",
                        LastName = "Marks",
                        BirthDate = DateTime.Parse("1977-10-14"),
                        Ssn = "999-85-1774",
                        ActivePatient = true,
                        Street = "243 Bartoletti Neck Suite 63",
                        City = "Sturbridge",
                        State = "Massachusetts",
                        Zip = "1507",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "ab3533aa-8230-4608",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-5-8"),
                        CreatedBy = "Davis, Everette",
                        Modified = DateTime.Parse("2019-7-18"),
                        ModifiedBy = "Gerhold, Joline"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Guillermo",
                        LastName = "Trantow",
                        BirthDate = DateTime.Parse("1977-6-24"),
                        Ssn = "999-62-4132",
                        ActivePatient = true,
                        Street = "1027 Satterfield Spur Unit 67",
                        City = "Richmond",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "3603cd65-53a3-424b",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-5-25"),
                        CreatedBy = "Trejo, Susana",
                        Modified = DateTime.Parse("2019-7-23"),
                        ModifiedBy = "Goldner, Alvin"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Nilsa",
                        LastName = "Luettgen",
                        BirthDate = DateTime.Parse("1988-1-31"),
                        Ssn = "999-73-1608",
                        ActivePatient = true,
                        Street = "1075 Stroman Meadow Suite 36",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "839a1278-6a98-497b",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-5-26"),
                        CreatedBy = "Rolfson, Sharmaine",
                        Modified = DateTime.Parse("2019-7-30"),
                        ModifiedBy = "Friesen, Mariano"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Blaine",
                        LastName = "Crona",
                        BirthDate = DateTime.Parse("1981-9-24"),
                        Ssn = "999-89-8150",
                        ActivePatient = true,
                        Street = "342 Johns Pathway",
                        City = "Arlington",
                        State = "Massachusetts",
                        Zip = "2474",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "61d63628-15e5-473a",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "adb4-1a21ac2bfe00",
                        Created = DateTime.Parse("2019-5-27"),
                        CreatedBy = "Kulas, Asha",
                        Modified = DateTime.Parse("2019-7-31"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "France",
                        LastName = "Thompson",
                        BirthDate = DateTime.Parse("1975-8-22"),
                        Ssn = "999-30-8077",
                        ActivePatient = true,
                        Street = "985 Shields Parade",
                        City = "newton",
                        State = "Massachusetts",
                        Zip = "2458",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "4a790a44-7955-4057",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "96de-1c7035c9a510",
                        Created = DateTime.Parse("2019-5-30"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2019-7-15"),
                        ModifiedBy = "Mosciski, Alfonso"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Vergie",
                        LastName = "Beer",
                        BirthDate = DateTime.Parse("1939-8-24"),
                        Ssn = "999-21-2915",
                        ActivePatient = true,
                        Street = "833 Bergstrom Byway",
                        City = "Fall River",
                        State = "Massachusetts",
                        Zip = "2720",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "d9894cce-5641-4126",
                        SecondaryInsurance = "Cigna Health",
                        SecondaryInsuranceID = "aafd-06acb9332fb3",
                        Created = DateTime.Parse("2019-6-3"),
                        CreatedBy = "Davis, Everette",
                        Modified = DateTime.Parse("2019-7-13"),
                        ModifiedBy = "Zboncak, Shavonne"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Alejandro",
                        LastName = "Treutel",
                        BirthDate = DateTime.Parse("1983-10-28"),
                        Ssn = "999-88-3842",
                        ActivePatient = true,
                        Street = "689 Johnson Esplanade Unit 40",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "9080acbd-4ce6-4c72",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "90fb-feb0872c9806",
                        Created = DateTime.Parse("2019-6-10"),
                        CreatedBy = "Gerhold, Joline",
                        Modified = DateTime.Parse("2019-7-26"),
                        ModifiedBy = "Romaguera, Reggie"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Reuben",
                        LastName = "Rolfson",
                        BirthDate = DateTime.Parse("1976-6-28"),
                        Ssn = "999-53-6507",
                        ActivePatient = true,
                        Street = "374 Davis Park",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "8fe4ef71-0edb-405e",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b3c8-ae6b5c92899f",
                        Created = DateTime.Parse("2019-6-19"),
                        CreatedBy = "Bode, Daniel",
                        Modified = DateTime.Parse("2019-9-2"),
                        ModifiedBy = "Watsica, Lory"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Odis",
                        LastName = "Rutherford",
                        BirthDate = DateTime.Parse("1964-2-29"),
                        Ssn = "999-23-1971",
                        ActivePatient = true,
                        Street = "323 Wintheiser Mall Suite 64",
                        City = "Somerville",
                        State = "Massachusetts",
                        Zip = "2138",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "b003aafe-cb06-47fd",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "bd4f-f8044b64b596",
                        Created = DateTime.Parse("2019-6-22"),
                        CreatedBy = "Sawayn, Luna",
                        Modified = DateTime.Parse("2019-8-3"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        FirstName = "Ozzie",
                        LastName = "Cummings",
                        BirthDate = DateTime.Parse("2018-11-2"),
                        Ssn = "999-61-9847",
                        ActivePatient = true,
                        Street = "972 Hilpert Spur Unit 37",
                        City = "Falmouth",
                        State = "Massachusetts",
                        Zip = "2540",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "5bff9560-f815-4e21",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "a72d-84e40413bace",
                        Created = DateTime.Parse("2019-6-22"),
                        CreatedBy = "Romaguera, Reggie",
                        Modified = DateTime.Parse("2019-9-11"),
                        ModifiedBy = "Paredes, Ana"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Victoria",
                        LastName = "Uribe",
                        BirthDate = DateTime.Parse("1983-1-20"),
                        Ssn = "999-31-1600",
                        ActivePatient = true,
                        Street = "860 Zemlak Port",
                        City = "Peabody",
                        State = "Massachusetts",
                        Zip = "1940",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "6d8d78d3-3e54-4f82",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "b244-bff830358515",
                        Created = DateTime.Parse("2019-7-14"),
                        CreatedBy = "Bode, Daniel",
                        Modified = DateTime.Parse("2019-8-30"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Sanda",
                        LastName = "Wolff",
                        BirthDate = DateTime.Parse("1957-8-29"),
                        Ssn = "999-53-2372",
                        ActivePatient = true,
                        Street = "200 Borer Fort Unit 59",
                        City = "Quincy",
                        State = "Massachusetts",
                        Zip = "2169",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-7-18"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2019-8-26"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Marquita",
                        LastName = "Orn",
                        BirthDate = DateTime.Parse("1985-4-3"),
                        Ssn = "999-85-6440",
                        ActivePatient = true,
                        Street = "994 Breitenberg Parade",
                        City = "Peabody",
                        State = "Massachusetts",
                        Zip = "1940",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        CurrentBalance = 411.35M,
                        Created = DateTime.Parse("2019-7-22"),
                        CreatedBy = "Romaguera, Reggie",
                        Modified = DateTime.Parse("2019-10-2"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Lane",
                        LastName = "Beer",
                        BirthDate = DateTime.Parse("1998-6-23"),
                        Ssn = "999-41-7219",
                        ActivePatient = true,
                        Street = "872 Satterfield Skyway",
                        City = "new Bedford",
                        State = "Massachusetts",
                        Zip = "2740",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "ced2c262-2431-4885",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-8-4"),
                        CreatedBy = "Bode, Daniel",
                        Modified = DateTime.Parse("2019-10-12"),
                        ModifiedBy = "Rolfson, Sharmaine"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Michael",
                        LastName = "Dare",
                        BirthDate = DateTime.Parse("1964-2-29"),
                        Ssn = "999-46-5215",
                        ActivePatient = true,
                        Street = "333 Walker Branch Suite 32",
                        City = "Somerville",
                        State = "Massachusetts",
                        Zip = "2138",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "0ca29d43-6456-426e",
                        SecondaryInsurance = "Humana",
                        SecondaryInsuranceID = "be49-02136f47485c",
                        Created = DateTime.Parse("2019-8-11"),
                        CreatedBy = "Rolfson, Sharmaine",
                        Modified = DateTime.Parse("2019-10-16"),
                        ModifiedBy = "Zboncak, Shavonne"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Marco Antonio",
                        LastName = "Hurtado",
                        BirthDate = DateTime.Parse("1983-4-3"),
                        Ssn = "999-83-6585",
                        ActivePatient = false,
                        Street = "552 Rippin Port",
                        City = "Revere",
                        State = "Massachusetts",
                        Zip = "2151",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "d171d808-1f31-4ad3",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "aba5-e03a2fa921c7",
                        Created = DateTime.Parse("2019-8-14"),
                        CreatedBy = "Bode, Daniel",
                        Modified = DateTime.Parse("2019-9-13"),
                        ModifiedBy = "Hegmann, Myrl"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Milissa",
                        LastName = "Veum",
                        BirthDate = DateTime.Parse("1961-8-22"),
                        Ssn = "999-60-7709",
                        ActivePatient = true,
                        Street = "723 Krajcik Forge Apt 47",
                        City = "Granby",
                        State = "Massachusetts",
                        Zip = "1033",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "59c1abc0-90b8-4cda",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "94b5-3e0673f652e5",
                        Created = DateTime.Parse("2019-8-14"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2019-10-17"),
                        ModifiedBy = "Davis, Everette"
                        },
                    new Patient
                        {
                        FirstName = "Essie",
                        LastName = "Schultz",
                        BirthDate = DateTime.Parse("2009-7-7"),
                        Ssn = "999-76-4196",
                        ActivePatient = true,
                        Street = "915 Jakubowski Meadow",
                        City = "West Newbury",
                        State = "Massachusetts",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "57c9b98b-35a2-4360",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "9a20-9958eaaeee7c",
                        Created = DateTime.Parse("2019-8-23"),
                        CreatedBy = "Berge, Ranae",
                        Modified = DateTime.Parse("2019-10-6"),
                        ModifiedBy = "Corwin, Shelly"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Maxwell",
                        LastName = "Koepp",
                        BirthDate = DateTime.Parse("1957-9-14"),
                        Ssn = "999-51-3162",
                        ActivePatient = true,
                        Street = "402 Huels Dale Suite 46",
                        City = "newton",
                        State = "Massachusetts",
                        Zip = "2458",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "6343cfd0-d47f-4a20",
                        SecondaryInsurance = "Humana",
                        SecondaryInsuranceID = "b561-b33d6441f372",
                        CurrentBalance = 220.85M,
                        Created = DateTime.Parse("2019-9-9"),
                        CreatedBy = "McLaughlin, Angle",
                        Modified = DateTime.Parse("2019-12-4"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Darrel",
                        LastName = "Breitenberg",
                        BirthDate = DateTime.Parse("1983-5-14"),
                        Ssn = "999-51-1482",
                        ActivePatient = true,
                        Street = "828 Pfannerstill Light Apt 19",
                        City = "newton",
                        State = "Massachusetts",
                        Zip = "2458",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "b9253891-6240-41f2",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "bb48-0582d13548c7",
                        Created = DateTime.Parse("2019-9-12"),
                        CreatedBy = "Ondricka, Bradley",
                        Modified = DateTime.Parse("2019-11-9"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Verla",
                        LastName = "Cassin",
                        BirthDate = DateTime.Parse("1978-3-18"),
                        Ssn = "999-36-6335",
                        ActivePatient = true,
                        Street = "863 Heller Lock",
                        City = "Cummington",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "9ea28ce1-de76-48b9",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "aa27-e99a7020ecce",
                        Created = DateTime.Parse("2019-9-13"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2019-12-2"),
                        ModifiedBy = "Thiel, Damion"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Otis",
                        LastName = "Johns",
                        BirthDate = DateTime.Parse("1956-7-16"),
                        Ssn = "999-67-8027",
                        ActivePatient = true,
                        Street = "1078 Simonis Fort Suite 51",
                        City = "Norwood",
                        State = "Massachusetts",
                        Zip = "2062",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-9-18"),
                        CreatedBy = "Kulas, Asha",
                        Modified = DateTime.Parse("2019-12-13"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Cherie",
                        LastName = "Collins",
                        BirthDate = DateTime.Parse("1956-1-31"),
                        Ssn = "999-98-1026",
                        ActivePatient = true,
                        Street = "471 VonRueden Light Suite 98",
                        City = "Westborough",
                        State = "Massachusetts",
                        Zip = "1581",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "cb80f082-ef26-4b9b",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "8daf-1e14c0a8dc18",
                        Created = DateTime.Parse("2019-9-25"),
                        CreatedBy = "Mills, Nigel",
                        Modified = DateTime.Parse("2019-12-12"),
                        ModifiedBy = "Romaguera, Reggie"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Art",
                        LastName = "Steuber",
                        BirthDate = DateTime.Parse("1969-9-22"),
                        Ssn = "999-48-3848",
                        ActivePatient = true,
                        Street = "1075 Armstrong View Apt 30",
                        City = "North Attleborough",
                        State = "Massachusetts",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        CurrentBalance = 1089.48M,
                        Created = DateTime.Parse("2019-10-8"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2019-11-12"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Cameron",
                        LastName = "Beatty",
                        BirthDate = DateTime.Parse("1953-8-22"),
                        Ssn = "999-58-6881",
                        ActivePatient = true,
                        Street = "748 Roob Center",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "8e6c298d-b33d-43be",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2019-10-16"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2020-1-11"),
                        ModifiedBy = "Lesch, Walton"
                        },
                    new Patient
                        {
                        FirstName = "Ernesto",
                        LastName = "Escobar",
                        BirthDate = DateTime.Parse("2005-4-19"),
                        Ssn = "999-63-6340",
                        ActivePatient = true,
                        Street = "830 Ortiz Crossing",
                        City = "East Longmeadow",
                        State = "Massachusetts",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "d4517f53-dad0-48c1",
                        SecondaryInsurance = "Cigna Health",
                        SecondaryInsuranceID = "9665-aa617ce81275",
                        Created = DateTime.Parse("2019-10-20"),
                        CreatedBy = "Heathcote, Wilson",
                        Modified = DateTime.Parse("2020-1-5"),
                        ModifiedBy = "Bode, Daniel"
                        },
                    new Patient
                        {
                        FirstName = "Mack",
                        LastName = "Kozey",
                        BirthDate = DateTime.Parse("2012-8-22"),
                        Ssn = "999-12-6201",
                        ActivePatient = true,
                        Street = "1042 Kub Branch",
                        City = "Millbury",
                        State = "Massachusetts",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "3c29784a-61df-498e",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "bc00-7697abe2c3df",
                        Created = DateTime.Parse("2019-10-27"),
                        CreatedBy = "Gurule, Eugenia",
                        Modified = DateTime.Parse("2020-1-1"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Johnny",
                        LastName = "Kassulke",
                        BirthDate = DateTime.Parse("1966-6-12"),
                        Ssn = "999-98-3422",
                        ActivePatient = true,
                        Street = "459 Feeney Road Suite 64",
                        City = "Quincy",
                        State = "Massachusetts",
                        Zip = "2169",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "d9b2e4c0-ce15-4a50",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b31f-d5c49a05e09e",
                        Created = DateTime.Parse("2019-11-14"),
                        CreatedBy = "Friesen, Mariano",
                        Modified = DateTime.Parse("2020-1-14"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Paula",
                        LastName = "Kuhlman",
                        BirthDate = DateTime.Parse("1993-3-18"),
                        Ssn = "999-11-9809",
                        ActivePatient = true,
                        Street = "226 Lehner Street Apt 24",
                        City = "Hudson",
                        State = "Massachusetts",
                        Zip = "1749",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "a3b90a9b-9cc4-493c",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "b646-2a4edd24d23e",
                        Created = DateTime.Parse("2019-11-16"),
                        CreatedBy = "Goldner, Alvin",
                        Modified = DateTime.Parse("2020-1-20"),
                        ModifiedBy = "Hegmann, Myrl"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Erwin",
                        LastName = "Graham",
                        BirthDate = DateTime.Parse("1986-12-20"),
                        Ssn = "999-51-5534",
                        ActivePatient = true,
                        Street = "611 Barrows Vale Suite 5",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "25bd6cc0-bf0f-4888",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "99ca-08671df4b401",
                        Created = DateTime.Parse("2019-11-19"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2020-1-22"),
                        ModifiedBy = "Trejo, Susana"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Kelly",
                        LastName = "Wiegand",
                        BirthDate = DateTime.Parse("1974-1-6"),
                        Ssn = "999-62-6472",
                        ActivePatient = true,
                        Street = "742 Feil Glen",
                        City = "Bridgewater",
                        State = "Massachusetts",
                        Zip = "2324",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "01b5a96a-d586-4f1a",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "9f63-7ea12126d89e",
                        Created = DateTime.Parse("2019-11-22"),
                        CreatedBy = "Paredes, Ana",
                        Modified = DateTime.Parse("2020-1-24"),
                        ModifiedBy = "Friesen, Mariano"
                        },
                    new Patient
                        {
                        FirstName = "Mariana",
                        LastName = "Ura�as",
                        BirthDate = DateTime.Parse("2006-9-6"),
                        Ssn = "999-97-8901",
                        ActivePatient = false,
                        Street = "129 Ruecker Frontage road",
                        City = "new Bedford",
                        State = "Massachusetts",
                        Zip = "2740",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "10db6001-b50d-4352",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "a56b-21d0c2c5b99c",
                        Created = DateTime.Parse("2019-11-25"),
                        CreatedBy = "Fadel, Steven",
                        Modified = DateTime.Parse("2020-2-23"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        FirstName = "Ronnie",
                        LastName = "Graham",
                        BirthDate = DateTime.Parse("2015-5-14"),
                        Ssn = "999-16-7847",
                        ActivePatient = true,
                        Street = "723 Cassin Grove Apt 13",
                        City = "Abington",
                        State = "Massachusetts",
                        Zip = "2351",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "27e974ae-a79e-42cd",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "8ead-fdf31942ed20",
                        Created = DateTime.Parse("2019-12-12"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2020-1-29"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Seymour",
                        LastName = "Bogan",
                        BirthDate = DateTime.Parse("1959-3-23"),
                        Ssn = "999-74-7209",
                        ActivePatient = true,
                        Street = "965 Harris Fort Suite 78",
                        City = "Wellfleet",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "89130e93-7fcb-4123",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "8e71-f8b702fe4501",
                        Created = DateTime.Parse("2019-12-14"),
                        CreatedBy = "Goyette, Anissa",
                        Modified = DateTime.Parse("2020-3-13"),
                        ModifiedBy = "Gurule, Eugenia"
                        },
                    new Patient
                        {
                        FirstName = "Harlan",
                        LastName = "Murazik",
                        BirthDate = DateTime.Parse("2008-12-16"),
                        Ssn = "999-11-3551",
                        ActivePatient = true,
                        Street = "969 Gleichner Bay",
                        City = "Wilmington",
                        State = "Massachusetts",
                        Zip = "1887",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "2ed8f251-7366-4f00",
                        SecondaryInsurance = "Humana",
                        SecondaryInsuranceID = "a3d8-a931bd63b312",
                        Created = DateTime.Parse("2019-12-15"),
                        CreatedBy = "Watsica, Lory",
                        Modified = DateTime.Parse("2020-2-21"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Brant",
                        LastName = "Ebert",
                        BirthDate = DateTime.Parse("1970-12-3"),
                        Ssn = "999-31-6484",
                        ActivePatient = true,
                        Street = "628 Senger Plaza",
                        City = "Norwell",
                        State = "Massachusetts",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "fd2ad292-034b-46b2",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "8e56-743218d87cbf",
                        Created = DateTime.Parse("2020-2-10"),
                        CreatedBy = "Heathcote, Wilson",
                        Modified = DateTime.Parse("2020-3-31"),
                        ModifiedBy = "Davis, Everette"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Rosario",
                        LastName = "Canales",
                        BirthDate = DateTime.Parse("2001-5-16"),
                        Ssn = "999-71-5460",
                        ActivePatient = true,
                        Street = "688 D'Amore Walk",
                        City = "Cambridge",
                        State = "Massachusetts",
                        Zip = "2138",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "a8296af6-7706-497b",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "be46-f5c101e7ce66",
                        Created = DateTime.Parse("2020-2-10"),
                        CreatedBy = "Bode, Daniel",
                        Modified = DateTime.Parse("2020-3-14"),
                        ModifiedBy = "Lesch, Walton"
                        },
                    new Patient
                        {
                        FirstName = "Rolland",
                        LastName = "Spencer",
                        BirthDate = DateTime.Parse("2005-3-1"),
                        Ssn = "999-61-8789",
                        ActivePatient = true,
                        Street = "223 Hickle Club Apt 84",
                        City = "Falmouth",
                        State = "Massachusetts",
                        Zip = "2540",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "7d3570f8-4282-4ef1",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "a049-30a53f488a07",
                        Created = DateTime.Parse("2020-2-23"),
                        CreatedBy = "McLaughlin, Angle",
                        Modified = DateTime.Parse("2020-4-7"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Yuriko",
                        LastName = "Jacobs",
                        BirthDate = DateTime.Parse("1957-8-29"),
                        Ssn = "999-58-3151",
                        ActivePatient = true,
                        Street = "306 Parisian Path Suite 58",
                        City = "Quincy",
                        State = "Massachusetts",
                        Zip = "2169",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "de69c3c1-8366-4160",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "91d4-ce6fa08c11b3",
                        Created = DateTime.Parse("2020-2-26"),
                        CreatedBy = "Goyette, Anissa",
                        Modified = DateTime.Parse("2020-5-4"),
                        ModifiedBy = "Kulas, Asha"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Reina",
                        LastName = "Huels",
                        BirthDate = DateTime.Parse("1951-8-27"),
                        Ssn = "999-82-6675",
                        ActivePatient = true,
                        Street = "849 Reichert Approach Apt 54",
                        City = "Taunton",
                        State = "Massachusetts",
                        Zip = "2718",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "6a59b037-c848-472c",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "be9a-f14c43160c6c",
                        Created = DateTime.Parse("2020-3-2"),
                        CreatedBy = "Kunze, Morton",
                        Modified = DateTime.Parse("2020-5-18"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Jeffrey",
                        LastName = "MacGyver",
                        BirthDate = DateTime.Parse("1959-7-3"),
                        Ssn = "999-92-4475",
                        ActivePatient = true,
                        Street = "802 Buckridge Pathway",
                        City = "Danvers",
                        State = "Massachusetts",
                        Zip = "1923",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "78880659-ddf6-4887",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "842d-a16adfd7acde",
                        Created = DateTime.Parse("2020-3-8"),
                        CreatedBy = "Zboncak, Shavonne",
                        Modified = DateTime.Parse("2020-4-29"),
                        ModifiedBy = "Lesch, Walton"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Renay",
                        LastName = "Schimmel",
                        BirthDate = DateTime.Parse("1958-12-14"),
                        Ssn = "999-83-9359",
                        ActivePatient = true,
                        Street = "803 Corkery Meadow Apt 47",
                        City = "Athol",
                        State = "Massachusetts",
                        Zip = "1331",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "7d7c9b72-4769-4e72",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "b837-358754bd7f0d",
                        Created = DateTime.Parse("2020-3-9"),
                        CreatedBy = "Kreiger, Leo",
                        Modified = DateTime.Parse("2020-5-5"),
                        ModifiedBy = "Goyette, Anissa"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Joe",
                        LastName = "Kuhic",
                        BirthDate = DateTime.Parse("1968-7-11"),
                        Ssn = "999-57-2160",
                        ActivePatient = true,
                        Street = "516 Murazik Spur",
                        City = "Raynham",
                        State = "Massachusetts",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "677a3742-0c21-4384",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "9dad-8ba06103c94d",
                        Created = DateTime.Parse("2020-3-29"),
                        CreatedBy = "Trejo, Susana",
                        Modified = DateTime.Parse("2020-6-21"),
                        ModifiedBy = "Paredes, Ana"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Jennell",
                        LastName = "Stamm",
                        BirthDate = DateTime.Parse("1939-8-24"),
                        Ssn = "999-90-5930",
                        ActivePatient = true,
                        Street = "927 Beahan Approach Unit 9",
                        City = "Fall River",
                        State = "Massachusetts",
                        Zip = "2720",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "47eeb051-490c-4a27",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-4-13"),
                        CreatedBy = "Rolfson, Sharmaine",
                        Modified = DateTime.Parse("2020-6-15"),
                        ModifiedBy = "Romaguera, Reggie"
                        },
                    new Patient
                        {
                        FirstName = "Rutha",
                        LastName = "Walter",
                        BirthDate = DateTime.Parse("2008-10-3"),
                        Ssn = "999-63-7725",
                        ActivePatient = true,
                        Street = "906 Stoltenberg Vista Apt 68",
                        City = "Acushnet",
                        State = "Massachusetts",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "a43dfba3-ed96-4663",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "8beb-18a06f5ab72c",
                        Created = DateTime.Parse("2020-4-18"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2020-6-2"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        FirstName = "Harold",
                        LastName = "Roberts",
                        BirthDate = DateTime.Parse("2011-11-27"),
                        Ssn = "999-55-1958",
                        ActivePatient = true,
                        Street = "684 Witting Passage Suite 95",
                        City = "Waltham",
                        State = "Massachusetts",
                        Zip = "2451",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "a1a34756-b007-4369",
                        SecondaryInsurance = "Aetna",
                        SecondaryInsuranceID = "93ef-61cb7b4b448c",
                        Created = DateTime.Parse("2020-4-25"),
                        CreatedBy = "Gerhold, Joline",
                        Modified = DateTime.Parse("2020-7-21"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Matthew",
                        LastName = "Trantow",
                        BirthDate = DateTime.Parse("1989-1-3"),
                        Ssn = "999-69-2149",
                        ActivePatient = true,
                        Street = "1067 Turner Center",
                        City = "newton",
                        State = "Massachusetts",
                        Zip = "2458",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "fa07dae4-3ab8-46d8",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "8e2e-766461ac7f6c",
                        Created = DateTime.Parse("2020-4-27"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2020-7-8"),
                        ModifiedBy = "Gurule, Eugenia"
                        },
                    new Patient
                        {
                        FirstName = "Maryetta",
                        LastName = "Rowe",
                        BirthDate = DateTime.Parse("2012-11-19"),
                        Ssn = "999-18-6547",
                        ActivePatient = true,
                        Street = "603 Blanda View",
                        City = "new Bedford",
                        State = "Massachusetts",
                        Zip = "2740",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "2dbf2669-2d65-4d84",
                        SecondaryInsurance = "Aetna",
                        SecondaryInsuranceID = "9388-0066f3960974",
                        Created = DateTime.Parse("2020-4-27"),
                        CreatedBy = "Heathcote, Wilson",
                        Modified = DateTime.Parse("2020-6-3"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Queenie",
                        LastName = "Gleason",
                        BirthDate = DateTime.Parse("1939-8-24"),
                        Ssn = "999-99-6812",
                        ActivePatient = true,
                        Street = "590 Schumm Ville Suite 47",
                        City = "Fall River",
                        State = "Massachusetts",
                        Zip = "2720",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "c99e64e7-3f31-4b7f",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "a81a-db34fead98e5",
                        Created = DateTime.Parse("2020-4-28"),
                        CreatedBy = "Zboncak, Shavonne",
                        Modified = DateTime.Parse("2020-6-6"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        FirstName = "Dorathy",
                        LastName = "Thompson",
                        BirthDate = DateTime.Parse("2018-10-21"),
                        Ssn = "999-97-8309",
                        ActivePatient = true,
                        Street = "1050 Heathcote Underpass",
                        City = "Acton",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "6f9718cf-0135-49bf",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "ab97-5b7d3c193f0c",
                        Created = DateTime.Parse("2020-5-4"),
                        CreatedBy = "Corwin, Shelly",
                        Modified = DateTime.Parse("2020-6-19"),
                        ModifiedBy = "DuBuque, Norris"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Lazaro",
                        LastName = "Senger",
                        BirthDate = DateTime.Parse("1994-1-25"),
                        Ssn = "999-29-1955",
                        ActivePatient = false,
                        Street = "320 Leffler Row",
                        City = "Sudbury",
                        State = "Massachusetts",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "bc9a941e-d611-499b",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "8c16-b0f3a165559e",
                        Created = DateTime.Parse("2020-5-31"),
                        CreatedBy = "Gurule, Eugenia",
                        Modified = DateTime.Parse("2020-7-6"),
                        ModifiedBy = "Paredes, Ana"
                        },
                    new Patient
                        {
                        FirstName = "Angel",
                        LastName = "Swift",
                        BirthDate = DateTime.Parse("2012-1-3"),
                        Ssn = "999-62-6858",
                        ActivePatient = true,
                        Street = "517 Weissnat Mall",
                        City = "Malden",
                        State = "Massachusetts",
                        Zip = "2148",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "c072e6ad-b03f-4eee",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "abe0-2dbc93bbadfe",
                        Created = DateTime.Parse("2020-6-9"),
                        CreatedBy = "Gerhold, Joline",
                        Modified = DateTime.Parse("2020-7-26"),
                        ModifiedBy = "Ondricka, Bradley"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Elouise",
                        LastName = "Rolfson",
                        BirthDate = DateTime.Parse("1966-11-1"),
                        Ssn = "999-45-5838",
                        ActivePatient = true,
                        Street = "353 Christiansen Passage Suite 28",
                        City = "Somerset",
                        State = "Massachusetts",
                        Zip = "2725",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "a5d91b13-babe-4d88",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "9647-ffea605640cb",
                        Created = DateTime.Parse("2020-6-22"),
                        CreatedBy = "Rau, Tereasa",
                        Modified = DateTime.Parse("2020-9-20"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Samara",
                        LastName = "Schimmel",
                        BirthDate = DateTime.Parse("1991-6-26"),
                        Ssn = "999-44-6117",
                        ActivePatient = true,
                        Street = "521 Kreiger Bridge Suite 7",
                        City = "Hudson",
                        State = "Massachusetts",
                        Zip = "1749",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "7a2e428b-cf7d-425e",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "be49-6cdf280c36e1",
                        Created = DateTime.Parse("2020-6-25"),
                        CreatedBy = "Rolfson, Nelia",
                        Modified = DateTime.Parse("2020-8-7"),
                        ModifiedBy = "Thiel, Damion"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Mittie",
                        LastName = "Leannon",
                        BirthDate = DateTime.Parse("1986-1-10"),
                        Ssn = "999-91-9286",
                        ActivePatient = true,
                        Street = "1064 Dietrich Neck",
                        City = "Quincy",
                        State = "Massachusetts",
                        Zip = "2169",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-6-29"),
                        CreatedBy = "McLaughlin, Angle",
                        Modified = DateTime.Parse("2020-9-24"),
                        ModifiedBy = "Heathcote, Wilson"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Monserrate",
                        LastName = "Carter",
                        BirthDate = DateTime.Parse("1915-11-21"),
                        Ssn = "999-17-7832",
                        ActivePatient = true,
                        Street = "267 Koss Loaf Unit 55",
                        City = "Cambridge",
                        State = "Massachusetts",
                        Zip = "2138",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-7-9"),
                        CreatedBy = "Gerhold, Joline",
                        Modified = DateTime.Parse("2020-8-17"),
                        ModifiedBy = "Corwin, Shelly"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Mee",
                        LastName = "Schamberger",
                        BirthDate = DateTime.Parse("1939-8-24"),
                        Ssn = "999-30-2868",
                        ActivePatient = true,
                        Street = "539 Greenfelder Stravenue",
                        City = "Fall River",
                        State = "Massachusetts",
                        Zip = "2720",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "14f92538-be5c-4de6",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "afb7-9d404fd3a8ae",
                        Created = DateTime.Parse("2020-7-10"),
                        CreatedBy = "Corwin, Shelly",
                        Modified = DateTime.Parse("2020-8-24"),
                        ModifiedBy = "Davis, Everette"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Miles",
                        LastName = "Gutkowski",
                        BirthDate = DateTime.Parse("1961-3-31"),
                        Ssn = "999-98-8986",
                        ActivePatient = true,
                        Street = "515 Ritchie Ville Suite 19",
                        City = "North Adams",
                        State = "Massachusetts",
                        Zip = "1247",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "1b37ae9f-f895-4f71",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "91b8-22bad1ed333a",
                        Created = DateTime.Parse("2020-7-12"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2020-9-27"),
                        ModifiedBy = "Trejo, Susana"
                        },
                    new Patient
                        {
                        FirstName = "Francisco",
                        LastName = "Prosacco",
                        BirthDate = DateTime.Parse("2006-12-17"),
                        Ssn = "999-72-6694",
                        ActivePatient = true,
                        Street = "729 Nienow Gateway",
                        City = "Townsend",
                        State = "Massachusetts",
                        Zip = "1469",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "21dd496c-2fec-4c9c",
                        SecondaryInsurance = "Cigna Health",
                        SecondaryInsuranceID = "a0fe-c11ad5b2cdea",
                        Created = DateTime.Parse("2020-7-27"),
                        CreatedBy = "DuBuque, Norris",
                        Modified = DateTime.Parse("2020-10-21"),
                        ModifiedBy = "Emard, Denisse"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Collin",
                        LastName = "Bernhard",
                        Suffix = "MD",
                        BirthDate = DateTime.Parse("1955-4-1"),
                        Ssn = "999-12-7777",
                        ActivePatient = true,
                        Street = "181 Boyer Landing",
                        City = "Dedham",
                        State = "Massachusetts",
                        Zip = "2026",
                        PrimaryInsurance = "UnitedHealthcare",
                        PrimaryInsuranceID = "51d10707-a8ca-46d9",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "81f7-e8da06a3386f",
                        Created = DateTime.Parse("2020-7-30"),
                        CreatedBy = "Friesen, Mariano",
                        Modified = DateTime.Parse("2020-9-8"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Emilee",
                        LastName = "Conn",
                        BirthDate = DateTime.Parse("1954-8-22"),
                        Ssn = "999-79-6931",
                        ActivePatient = true,
                        Street = "980 Barrows Path Apt 31",
                        City = "Gloucester",
                        State = "Massachusetts",
                        Zip = "1930",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "d41d57b4-91e6-4452",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "8b31-937d707d2b3f",
                        Created = DateTime.Parse("2020-8-19"),
                        CreatedBy = "Goyette, Anissa",
                        Modified = DateTime.Parse("2020-10-10"),
                        ModifiedBy = "Gerhold, Joline"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Tom",
                        LastName = "Dach",
                        BirthDate = DateTime.Parse("1982-9-2"),
                        Ssn = "999-51-6592",
                        ActivePatient = true,
                        Street = "322 Labadie Ramp Suite 51",
                        City = "Revere",
                        State = "Massachusetts",
                        Zip = "2151",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "870a8160-e247-4758",
                        SecondaryInsurance = "Humana",
                        SecondaryInsuranceID = "a414-073fd676592d",
                        Created = DateTime.Parse("2020-9-2"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2020-11-8"),
                        ModifiedBy = "Gerhold, Joline"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Dusti",
                        LastName = "Osinski",
                        BirthDate = DateTime.Parse("1997-1-15"),
                        Ssn = "999-94-2070",
                        ActivePatient = true,
                        Street = "224 Rowe Key",
                        City = "Yarmouth",
                        State = "Massachusetts",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "44b08ecf-2044-4a15",
                        SecondaryInsurance = "Aetna",
                        SecondaryInsuranceID = "9eed-426a5bd3688b",
                        Created = DateTime.Parse("2020-9-6"),
                        CreatedBy = "Zboncak, Shavonne",
                        Modified = DateTime.Parse("2020-11-16"),
                        ModifiedBy = "Rolfson, Nelia"
                        },
                    new Patient
                        {
                        FirstName = "Alex",
                        LastName = "Prosacco",
                        BirthDate = DateTime.Parse("2002-1-20"),
                        Ssn = "999-75-8538",
                        ActivePatient = true,
                        Street = "808 Abbott Parade Apt 80",
                        City = "Lawrence",
                        State = "Massachusetts",
                        Zip = "1840",
                        PrimaryInsurance = "Cigna Health",
                        PrimaryInsuranceID = "ffdeb4e3-eaa0-4139",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "bf21-2243370b31d0",
                        Created = DateTime.Parse("2020-9-9"),
                        CreatedBy = "Mills, Nigel",
                        Modified = DateTime.Parse("2020-11-2"),
                        ModifiedBy = "Romaguera, Reggie"
                        },
                    new Patient
                        {
                        FirstName = "Gabriella",
                        LastName = "Cartwright",
                        BirthDate = DateTime.Parse("2019-7-2"),
                        Ssn = "999-80-2569",
                        ActivePatient = true,
                        Street = "161 D'Amore Stravenue",
                        City = "Worcester",
                        State = "Massachusetts",
                        Zip = "1545",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "8ccf09f3-07c3-4d93",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "9389-48574072ebc7",
                        Created = DateTime.Parse("2020-9-12"),
                        CreatedBy = "Trejo, Susana",
                        Modified = DateTime.Parse("2020-12-5"),
                        ModifiedBy = "Gerhold, Joline"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Tiffanie",
                        LastName = "Marks",
                        BirthDate = DateTime.Parse("1958-7-22"),
                        Ssn = "999-73-2288",
                        ActivePatient = true,
                        Street = "565 Torphy Hollow",
                        City = "Medway",
                        State = "Massachusetts",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "7125b58e-8953-46db",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "9573-537b34888d8f",
                        Created = DateTime.Parse("2020-9-14"),
                        CreatedBy = "Ondricka, Bradley",
                        Modified = DateTime.Parse("2020-11-12"),
                        ModifiedBy = "Davis, Everette"
                        },
                    new Patient
                        {
                        Prefix = "Ms.",
                        FirstName = "Angele",
                        LastName = "Konopelski",
                        BirthDate = DateTime.Parse("1966-8-13"),
                        Ssn = "999-88-5291",
                        ActivePatient = true,
                        Street = "921 Roberts Rue Apt 73",
                        City = "Marblehead",
                        State = "Massachusetts",
                        Zip = "1945",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "2c405456-ee6d-475c",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "b0fe-e8675589845c",
                        Created = DateTime.Parse("2020-9-17"),
                        CreatedBy = "Trejo, Susana",
                        Modified = DateTime.Parse("2020-12-12"),
                        ModifiedBy = "Berge, Ranae"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Cedric",
                        LastName = "Mayer",
                        BirthDate = DateTime.Parse("1972-11-20"),
                        Ssn = "999-19-6777",
                        ActivePatient = true,
                        Street = "896 Murazik Club",
                        City = "Arlington",
                        State = "Massachusetts",
                        Zip = "2474",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "9c87abae-4487-45f4",
                        SecondaryInsurance = "Anthem",
                        SecondaryInsuranceID = "b29c-b481a4e88bc0",
                        Created = DateTime.Parse("2020-9-23"),
                        CreatedBy = "Hegmann, Myrl",
                        Modified = DateTime.Parse("2020-11-21"),
                        ModifiedBy = "Rolfson, Sharmaine"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Luther",
                        LastName = "Abernathy",
                        BirthDate = DateTime.Parse("1978-10-2"),
                        Ssn = "999-41-3666",
                        ActivePatient = true,
                        Street = "1013 Ziemann Quay",
                        City = "Grafton",
                        State = "Massachusetts",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-9-28"),
                        CreatedBy = "Trejo, Susana",
                        Modified = DateTime.Parse("2020-12-9"),
                        ModifiedBy = "Davis, Everette"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Lucretia",
                        LastName = "McCullough",
                        BirthDate = DateTime.Parse("1941-4-6"),
                        Ssn = "999-94-4604",
                        ActivePatient = true,
                        Street = "213 Walsh Dam",
                        City = "Mattapoisett",
                        State = "Massachusetts",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "c89380ce-c811-4e2f",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "aaef-e7020efa6dfd",
                        Created = DateTime.Parse("2020-9-29"),
                        CreatedBy = "Gurule, Eugenia",
                        Modified = DateTime.Parse("2020-12-27"),
                        ModifiedBy = "Lesch, Walton"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Lottie",
                        LastName = "Cole",
                        BirthDate = DateTime.Parse("1985-2-20"),
                        Ssn = "999-39-8322",
                        ActivePatient = false,
                        Street = "387 Reilly Overpass",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "95f96486-b915-4e2c",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-9-29"),
                        CreatedBy = "Sawayn, Luna",
                        Modified = DateTime.Parse("2020-11-11"),
                        ModifiedBy = "Bode, Daniel"
                        },
                    new Patient
                        {
                        FirstName = "Marketta",
                        LastName = "Zieme",
                        BirthDate = DateTime.Parse("2008-5-9"),
                        Ssn = "999-79-5273",
                        ActivePatient = true,
                        Street = "428 O'Reilly Highlands",
                        City = "Framingham",
                        State = "Massachusetts",
                        Zip = "1701",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-10-15"),
                        CreatedBy = "Rau, Tereasa",
                        Modified = DateTime.Parse("2020-12-6"),
                        ModifiedBy = "Mills, Nigel"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Jenise",
                        LastName = "Stokes",
                        BirthDate = DateTime.Parse("1950-9-30"),
                        Ssn = "999-46-4548",
                        ActivePatient = true,
                        Street = "689 Beer Wall Suite 41",
                        City = "Canton",
                        State = "Massachusetts",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "02b253ec-2379-4334",
                        SecondaryInsurance = "Dual Eligible",
                        SecondaryInsuranceID = "87fa-b959e7838ed4",
                        Created = DateTime.Parse("2020-10-19"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2020-12-20"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Monte",
                        LastName = "McClure",
                        BirthDate = DateTime.Parse("1975-7-11"),
                        Ssn = "999-10-9993",
                        ActivePatient = true,
                        Street = "795 Goyette Junction",
                        City = "Wilbraham",
                        State = "Massachusetts",
                        Zip = "1095",
                        PrimaryInsurance = "None",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-10-24"),
                        CreatedBy = "Mills, Nigel",
                        Modified = DateTime.Parse("2020-11-27"),
                        ModifiedBy = "DuBuque, Norris"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Keisha",
                        LastName = "Kris",
                        BirthDate = DateTime.Parse("1990-11-19"),
                        Ssn = "999-20-9744",
                        ActivePatient = true,
                        Street = "362 Dickens Boulevard",
                        City = "Boston",
                        State = "Massachusetts",
                        Zip = "2108",
                        PrimaryInsurance = "Medicaid",
                        PrimaryInsuranceID = "24aba9a1-2e73-4d31",
                        SecondaryInsurance = "Aetna",
                        SecondaryInsuranceID = "ab80-7d8a43beda74",
                        Created = DateTime.Parse("2020-11-6"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2020-12-22"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Herna�n",
                        LastName = "Ojeda",
                        BirthDate = DateTime.Parse("1991-10-21"),
                        Ssn = "999-65-7753",
                        ActivePatient = true,
                        Street = "257 Bradtke Mill Unit 35",
                        City = "newton",
                        State = "Massachusetts",
                        Zip = "2458",
                        PrimaryInsurance = "Humana",
                        PrimaryInsuranceID = "bd512b17-9e68-4b0e",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "8c5b-980007ecdee1",
                        Created = DateTime.Parse("2020-11-15"),
                        CreatedBy = "Hegmann, Myrl",
                        Modified = DateTime.Parse("2020-12-31"),
                        ModifiedBy = "Thiel, Damion"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Mellie",
                        LastName = "Koepp",
                        BirthDate = DateTime.Parse("1951-6-21"),
                        Ssn = "999-38-7353",
                        ActivePatient = true,
                        Street = "1015 Ryan Port",
                        City = "Fall River",
                        State = "Massachusetts",
                        Zip = "2720",
                        PrimaryInsurance = "Dual Eligible",
                        PrimaryInsuranceID = "d29d3202-fa44-4efb",
                        SecondaryInsurance = "Cigna Health",
                        SecondaryInsuranceID = "b1ec-bc2c4d548868",
                        Created = DateTime.Parse("2020-11-16"),
                        CreatedBy = "Lesch, Walton",
                        Modified = DateTime.Parse("2021-1-20"),
                        ModifiedBy = "Bode, Daniel"
                        },
                    new Patient
                        {
                        FirstName = "Jeremiah",
                        LastName = "Hane",
                        BirthDate = DateTime.Parse("2017-6-26"),
                        Ssn = "999-25-7686",
                        ActivePatient = true,
                        Street = "941 Hand Forge Unit 91",
                        City = "Somerset",
                        State = "Massachusetts",
                        Zip = "2725",
                        PrimaryInsurance = "Medicare",
                        PrimaryInsuranceID = "ab132b8f-1200-497d",
                        SecondaryInsurance = "None",
                        Created = DateTime.Parse("2020-11-20"),
                        CreatedBy = "Watsica, Lory",
                        Modified = DateTime.Parse("2021-1-16"),
                        ModifiedBy = "Watsica, Lory"
                        },
                    new Patient
                        {
                        FirstName = "Georgina",
                        LastName = "Schiller",
                        BirthDate = DateTime.Parse("2008-9-24"),
                        Ssn = "999-11-6600",
                        ActivePatient = true,
                        Street = "157 Carter Forge Unit 88",
                        City = "North Andover",
                        State = "Massachusetts",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "3e92b479-ea5b-4191",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "b36b-b983746fb1b0",
                        Created = DateTime.Parse("2020-11-21"),
                        CreatedBy = "Mills, Nigel",
                        Modified = DateTime.Parse("2021-2-8"),
                        ModifiedBy = "Sawayn, Luna"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Sean",
                        LastName = "Luettgen",
                        BirthDate = DateTime.Parse("1988-2-28"),
                        Ssn = "999-10-2971",
                        ActivePatient = true,
                        Street = "241 Lubowitz Skyway",
                        City = "Canton",
                        State = "Massachusetts",
                        PrimaryInsurance = "Aetna",
                        PrimaryInsuranceID = "31c864af-38ad-476c",
                        SecondaryInsurance = "Blue Cross Blue Shield",
                        SecondaryInsuranceID = "8061-fa3bc461a363",
                        Created = DateTime.Parse("2020-12-6"),
                        CreatedBy = "Rau, Tereasa",
                        Modified = DateTime.Parse("2021-1-8"),
                        ModifiedBy = "Gerhold, Joline"
                        },
                    new Patient
                        {
                        FirstName = "Claudine",
                        LastName = "Schuppe",
                        BirthDate = DateTime.Parse("2010-2-18"),
                        Ssn = "999-59-9082",
                        ActivePatient = true,
                        Street = "864 Kovacek Landing",
                        City = "Norwood",
                        State = "Massachusetts",
                        Zip = "2062",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "a9df73f7-dd25-4b5b",
                        SecondaryInsurance = "Medicaid",
                        SecondaryInsuranceID = "b924-938edabfb461",
                        Created = DateTime.Parse("2020-12-10"),
                        CreatedBy = "Paredes, Ana",
                        Modified = DateTime.Parse("2021-2-13"),
                        ModifiedBy = "Fadel, Steven"
                        },
                    new Patient
                        {
                        Prefix = "Mrs.",
                        FirstName = "Danuta",
                        LastName = "Franecki",
                        BirthDate = DateTime.Parse("1992-7-27"),
                        Ssn = "999-17-5629",
                        ActivePatient = true,
                        Street = "196 Herzog Rest",
                        City = "Lowell",
                        State = "Massachusetts",
                        Zip = "1850",
                        PrimaryInsurance = "Anthem",
                        PrimaryInsuranceID = "4bd5735c-7c58-4e89",
                        SecondaryInsurance = "Medicare",
                        SecondaryInsuranceID = "a42d-7b36402ca44d",
                        Created = DateTime.Parse("2020-12-15"),
                        CreatedBy = "Fadel, Steven",
                        Modified = DateTime.Parse("2021-1-29"),
                        ModifiedBy = "Kreiger, Leo"
                        },
                    new Patient
                        {
                        Prefix = "Mr.",
                        FirstName = "Luther",
                        LastName = "Sanford",
                        BirthDate = DateTime.Parse("1968-5-24"),
                        Ssn = "999-69-3582",
                        ActivePatient = true,
                        Street = "381 Tremblay Overpass Apt 77",
                        City = "Shrewsbury",
                        State = "Massachusetts",
                        PrimaryInsurance = "Blue Cross Blue Shield",
                        PrimaryInsuranceID = "949e3e66-aa54-4a00",
                        SecondaryInsurance = "UnitedHealthcare",
                        SecondaryInsuranceID = "be94-204bf0696852",
                        Created = DateTime.Parse("2020-12-25"),
                        CreatedBy = "Emard, Denisse",
                        Modified = DateTime.Parse("2021-1-31"),
                        ModifiedBy = "Hegmann, Myrl"
                        }
                };
            patients.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            var referrals = new List<Referral>
                {
                new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-8"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Davis, Everette",
                        Procedure = "Standard pregnancy test",
                        Location = "Saperia Orthopaedics And Sports Medicine Inc",
                        Created = DateTime.Parse("2019-4-19"),
                        CreatedBy = "Corkery, Johnny",
                        Modified = DateTime.Parse("2019-5-23"),
                        ModifiedBy = "Kertzmann, Zack",
                        PatientId = 37
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-7-21"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Mammogram - symptomatic (procedure)",
                        Location = "Auburn Podiatry Llp",
                        Created = DateTime.Parse("2020-1-2"),
                        CreatedBy = "Wilderman, Darnell",
                        Modified = DateTime.Parse("2020-4-7"),
                        ModifiedBy = "Cole, Olympia",
                        PatientId = 47
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-9"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Trejo, Susana",
                        Procedure = "Insertion of subcutaneous contraceptive",
                        Location = "Boston Children'S Hospital",
                        Created = DateTime.Parse("2020-8-24"),
                        CreatedBy = "Kuhn, Valentine",
                        Modified = DateTime.Parse("2020-11-18"),
                        ModifiedBy = "Buckridge, Osvaldo",
                        PatientId = 27
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-8"),
                        Doctor = "Corwin, Shelly",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Referral to hypertension clinic",
                        Location = "Nutrition For Life  Inc.",
                        Created = DateTime.Parse("2020-4-11"),
                        CreatedBy = "Block, Penni",
                        Modified = DateTime.Parse("2020-6-13"),
                        ModifiedBy = "Trantow, Andrew",
                        PatientId = 88
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-27"),
                        Doctor = "Kulas, Asha",
                        ReferralDoctor = "Davis, Everette",
                        Procedure = "Injection of adrenaline",
                        Location = "Winchester Lahey Inpatient Specialists Pllc",
                        Created = DateTime.Parse("2020-8-22"),
                        CreatedBy = "Stiedemann, Aaron",
                        Modified = DateTime.Parse("2020-11-26"),
                        ModifiedBy = "Arellano, Bernardo",
                        PatientId = 72
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-27"),
                        Doctor = "Hegmann, Myrl",
                        ReferralDoctor = "Friesen, Mariano",
                        Procedure = "Cytopathology procedure  preparation of smear  genital source (procedure)",
                        Location = "Progressive Physician Associates Inc",
                        Created = DateTime.Parse("2020-6-5"),
                        CreatedBy = "Fahey, Ashley",
                        Modified = DateTime.Parse("2020-8-10"),
                        ModifiedBy = "Quigley, Rashad",
                        PatientId = 93
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-7-25"),
                        Doctor = "Lesch, Walton",
                        ReferralDoctor = "Fadel, Steven",
                        Procedure = "Excision of axillary lymph node (procedure)",
                        Location = "Causeway Opc",
                        Created = DateTime.Parse("2019-6-2"),
                        CreatedBy = "Cassin, Georgann",
                        Modified = DateTime.Parse("2019-9-19"),
                        ModifiedBy = "Moen, Quinn",
                        PatientId = 77
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-3-2"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Fadel, Steven",
                        Procedure = "Counseling for termination of pregnancy",
                        Location = "Good Samaritan Medical Center",
                        Created = DateTime.Parse("2019-10-16"),
                        CreatedBy = "Delgado, Barbara",
                        Modified = DateTime.Parse("2020-1-10"),
                        ModifiedBy = "Sipes, Shelia",
                        PatientId = 32
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-12-18"),
                        Doctor = "Kulas, Asha",
                        ReferralDoctor = "Ondricka, Bradley",
                        Procedure = "Chlamydia antigen test",
                        Location = "Sturdy Memorial Hospital Inc",
                        Created = DateTime.Parse("2019-1-8"),
                        CreatedBy = "Bergstrom, Elias",
                        Modified = DateTime.Parse("2019-4-16"),
                        ModifiedBy = "Jerde, Jackson",
                        PatientId = 87
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-6-9"),
                        Doctor = "Mosciski, Alfonso",
                        ReferralDoctor = "Mills, Nigel",
                        Procedure = "Teleradiotherapy procedure (procedure)",
                        Location = "Jonathan Rothman Md",
                        Created = DateTime.Parse("2020-8-14"),
                        CreatedBy = "Mertz, Noel",
                        Modified = DateTime.Parse("2020-11-13"),
                        ModifiedBy = "Rosenbaum, Al",
                        PatientId = 51
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-8-6"),
                        Doctor = "Bode, Daniel",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Replacement of subcutaneous contraceptive",
                        Location = "Exeter Eye Associates Llc",
                        Created = DateTime.Parse("2019-3-3"),
                        CreatedBy = "Grady, Blair",
                        Modified = DateTime.Parse("2019-5-8"),
                        ModifiedBy = "Miller, Chelsea",
                        PatientId = 8
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-3"),
                        Doctor = "Mosciski, Alfonso",
                        ReferralDoctor = "McLaughlin, Angle",
                        Procedure = "Injection of adrenaline",
                        Location = "Dental Surgeons Of Fall River Pc",
                        Created = DateTime.Parse("2019-1-19"),
                        CreatedBy = "Lowe, Landon",
                        Modified = DateTime.Parse("2019-5-9"),
                        ModifiedBy = "Torp, Ty",
                        PatientId = 8
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-22"),
                        Doctor = "Kulas, Asha",
                        ReferralDoctor = "Bode, Daniel",
                        Procedure = "Evaluation of uterine fundal height",
                        Location = "South Shore Hospital",
                        Created = DateTime.Parse("2020-4-21"),
                        CreatedBy = "Rosenbaum, Ezequiel",
                        Modified = DateTime.Parse("2020-7-1"),
                        ModifiedBy = "O'Conner, Paulina",
                        PatientId = 30
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-12-11"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Berge, Ranae",
                        Procedure = "Replacement of contraceptive intrauterine device",
                        Location = "Family Health Center",
                        Created = DateTime.Parse("2020-10-30"),
                        CreatedBy = "Larson, Ardelia",
                        Modified = DateTime.Parse("2021-2-4"),
                        ModifiedBy = "Runolfsdottir, Jefferson",
                        PatientId = 12
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-15"),
                        Doctor = "Fadel, Steven",
                        ReferralDoctor = "Berge, Ranae",
                        Procedure = "Human immunodeficiency virus antigen test",
                        Location = "Odonata Psychotherapy And Retreat Center Llc",
                        Created = DateTime.Parse("2019-5-5"),
                        CreatedBy = "McDermott, Chris",
                        Modified = DateTime.Parse("2019-7-28"),
                        ModifiedBy = "Osinski, Shameka",
                        PatientId = 82
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-11-10"),
                        Doctor = "Paredes, Ana",
                        ReferralDoctor = "Ondricka, Bradley",
                        Procedure = "Physical examination following birth",
                        Location = "Anchor Medical Group And Wellness Center Pc",
                        Created = DateTime.Parse("2019-7-15"),
                        CreatedBy = "Hammes, Emory",
                        Modified = DateTime.Parse("2019-10-7"),
                        ModifiedBy = "Moen, Cheri",
                        PatientId = 70
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-8-22"),
                        Doctor = "Thiel, Damion",
                        ReferralDoctor = "Paredes, Ana",
                        Procedure = "Review of systems (procedure)",
                        Location = "Vhm Services Inc",
                        Created = DateTime.Parse("2020-12-4"),
                        CreatedBy = "Raynor, Elvera",
                        Modified = DateTime.Parse("2021-3-14"),
                        ModifiedBy = "Senger, Kristofer",
                        PatientId = 88
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-7-31"),
                        Doctor = "Ondricka, Bradley",
                        ReferralDoctor = "Kreiger, Leo",
                        Procedure = "Sputum examination (procedure)",
                        Location = "Chmc Surgical Foundation Inc",
                        Created = DateTime.Parse("2019-8-20"),
                        CreatedBy = "Gutmann, Wonda",
                        Modified = DateTime.Parse("2019-11-27"),
                        ModifiedBy = "Zieme, Ricky",
                        PatientId = 73
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-3-27"),
                        Doctor = "Gerhold, Joline",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Prostatectomy",
                        Location = "High Point Treatment Center Inc.",
                        Created = DateTime.Parse("2019-1-4"),
                        CreatedBy = "Reynolds, Gregory",
                        Modified = DateTime.Parse("2019-4-2"),
                        ModifiedBy = "Grady, Shona",
                        PatientId = 84
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-11-14"),
                        Doctor = "Friesen, Mariano",
                        ReferralDoctor = "Goyette, Anissa",
                        Procedure = "Sputum examination (procedure)",
                        Location = "Umass Memorial Medical Group  Inc.",
                        Created = DateTime.Parse("2020-7-29"),
                        CreatedBy = "Ebert, Shannon",
                        Modified = DateTime.Parse("2020-9-15"),
                        ModifiedBy = "Esta�vez, Luis Miguel",
                        PatientId = 37
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-7-4"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Davis, Everette",
                        Procedure = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
                        Location = "Carewell Urgent Care Centers Of Ma  Pc",
                        Created = DateTime.Parse("2019-9-13"),
                        CreatedBy = "Blick, Britt",
                        Modified = DateTime.Parse("2019-10-14"),
                        ModifiedBy = "Verdugo, Mateo",
                        PatientId = 16
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-5-1"),
                        Doctor = "Kreiger, Leo",
                        ReferralDoctor = "Romaguera, Reggie",
                        Procedure = "Excision of fallopian tube and surgical removal of ectopic pregnancy",
                        Location = "Massachusetts General Physicians Organization  Inc",
                        Created = DateTime.Parse("2020-9-22"),
                        CreatedBy = "Nikolaus, Gonzalo",
                        Modified = DateTime.Parse("2020-12-30"),
                        ModifiedBy = "Monahan, Jame",
                        PatientId = 9
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-28"),
                        Doctor = "Davis, Everette",
                        ReferralDoctor = "DuBuque, Norris",
                        Procedure = "Ultrasonography of bilateral breasts (procedure)",
                        Location = "Cape Cod Pain Management  Pc",
                        Created = DateTime.Parse("2020-5-11"),
                        CreatedBy = "Turcotte, Helga",
                        Modified = DateTime.Parse("2020-8-10"),
                        ModifiedBy = "Wintheiser, Ronni",
                        PatientId = 85
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-1-1"),
                        Doctor = "Romaguera, Reggie",
                        ReferralDoctor = "Romaguera, Reggie",
                        Procedure = "Laparoscopic Removal of Gall Bladder",
                        Location = "Medical Associates Of Greater Boston",
                        Created = DateTime.Parse("2020-11-10"),
                        CreatedBy = "Nolan, Cedrick",
                        Modified = DateTime.Parse("2020-12-24"),
                        ModifiedBy = "Kilback, Antonia",
                        PatientId = 36
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-14"),
                        Doctor = "Corwin, Shelly",
                        ReferralDoctor = "Friesen, Mariano",
                        Procedure = "Construction of diverting colostomy",
                        Location = "Proex Physical Therapy  Llc",
                        Created = DateTime.Parse("2019-2-23"),
                        CreatedBy = "Johnson, Faustino",
                        Modified = DateTime.Parse("2019-4-16"),
                        ModifiedBy = "Mosciski, Wilfredo",
                        PatientId = 9
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-19"),
                        Doctor = "Rau, Tereasa",
                        ReferralDoctor = "Friesen, Mariano",
                        Procedure = "Removal of subcutaneous contraceptive",
                        Location = "Nephrology Asssociates Of The Merrimack Valley Pc",
                        Created = DateTime.Parse("2019-8-13"),
                        CreatedBy = "Robel, Ezra",
                        Modified = DateTime.Parse("2019-12-11"),
                        ModifiedBy = "Weber, Janean",
                        PatientId = 14
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-5-4"),
                        Doctor = "Bode, Daniel",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Epidural anesthesia",
                        Location = "Adult Behavioral Services Llc",
                        Created = DateTime.Parse("2020-9-15"),
                        CreatedBy = "Grimes, Andre",
                        Modified = DateTime.Parse("2020-11-14"),
                        ModifiedBy = "Ebert, Shannon",
                        PatientId = 6
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-5"),
                        Doctor = "Gurule, Eugenia",
                        ReferralDoctor = "Rolfson, Sharmaine",
                        Procedure = "Admission to orthopedic department",
                        Location = "Andover Obstetrics And Gynecological Associates Pc",
                        Created = DateTime.Parse("2020-10-10"),
                        CreatedBy = "Zambrano, Da�bora",
                        Modified = DateTime.Parse("2021-1-18"),
                        ModifiedBy = "Jerde, Mariana",
                        PatientId = 68
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-12"),
                        Doctor = "Trejo, Susana",
                        ReferralDoctor = "Ondricka, Bradley",
                        Procedure = "Measurement of Varicella-zoster virus antibody",
                        Location = "Proex Physical Therapy  Llc",
                        Created = DateTime.Parse("2020-7-31"),
                        CreatedBy = "Hegmann, Myrl",
                        Modified = DateTime.Parse("2020-11-10"),
                        ModifiedBy = "Rempel, Haywood",
                        PatientId = 9
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-12-8"),
                        Doctor = "Friesen, Mariano",
                        ReferralDoctor = "Hegmann, Myrl",
                        Procedure = "Allergy screening test",
                        Location = "Boston Children'S Hospital",
                        Created = DateTime.Parse("2019-9-28"),
                        CreatedBy = "Ratke, Gaston",
                        Modified = DateTime.Parse("2019-10-28"),
                        ModifiedBy = "Reilly, Neville",
                        PatientId = 51
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-10-3"),
                        Doctor = "Davis, Everette",
                        ReferralDoctor = "Bode, Daniel",
                        Procedure = "Hearing examination (procedure)",
                        Location = "Community Chiropractic Of Groton Inc.",
                        Created = DateTime.Parse("2020-11-25"),
                        CreatedBy = "Sipes, Pinkie",
                        Modified = DateTime.Parse("2021-1-28"),
                        ModifiedBy = "Leffler, Latia",
                        PatientId = 52
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-12-20"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Goyette, Anissa",
                        Procedure = "Colonoscopy",
                        Location = "Gateway Physical Therapy And Wellness Corp",
                        Created = DateTime.Parse("2019-4-1"),
                        CreatedBy = "Rodra�guez, Ernesto",
                        Modified = DateTime.Parse("2019-6-30"),
                        ModifiedBy = "Rau, Justin",
                        PatientId = 13
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-14"),
                        Doctor = "Mills, Nigel",
                        ReferralDoctor = "Watsica, Lory",
                        Procedure = "Diagnostic fiberoptic bronchoscopy (procedure)",
                        Location = "Adcare Hospital Of Worcester Inc",
                        Created = DateTime.Parse("2019-6-2"),
                        CreatedBy = "Rau, Justin",
                        Modified = DateTime.Parse("2019-8-30"),
                        ModifiedBy = "Parisian, Crista",
                        PatientId = 30
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-16"),
                        Doctor = "Berge, Ranae",
                        ReferralDoctor = "Gurule, Eugenia",
                        Procedure = "Ultrasound scan for fetal viability",
                        Location = "Baystate Franklin Medical Center",
                        Created = DateTime.Parse("2019-8-9"),
                        CreatedBy = "Trantow, Andrew",
                        Modified = DateTime.Parse("2019-10-7"),
                        ModifiedBy = "Gusikowski, Lavern",
                        PatientId = 40
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-8-6"),
                        Doctor = "Ondricka, Bradley",
                        ReferralDoctor = "Romaguera, Reggie",
                        Procedure = "Screening mammography (procedure)",
                        Location = "Allergy Affiliates Of Danvers",
                        Created = DateTime.Parse("2019-2-25"),
                        CreatedBy = "Schultz, Henry",
                        Modified = DateTime.Parse("2019-5-17"),
                        ModifiedBy = "Rodriguez, Jeremiah",
                        PatientId = 76
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-12-2"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Zboncak, Shavonne",
                        Procedure = "Vasectomy",
                        Location = "Harvard Vanguard Braintree Practice Urgent Care",
                        Created = DateTime.Parse("2019-2-19"),
                        CreatedBy = "Olson, Vergie",
                        Modified = DateTime.Parse("2019-4-15"),
                        ModifiedBy = "Kiehn, Cameron",
                        PatientId = 11
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-6"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Berge, Ranae",
                        Procedure = "Human immunodeficiency virus antigen test",
                        Location = "Greater Milford Neurology  Llc",
                        Created = DateTime.Parse("2019-10-3"),
                        CreatedBy = "Rodriguez, Julio",
                        Modified = DateTime.Parse("2019-11-29"),
                        ModifiedBy = "Gaylord, Sau",
                        PatientId = 13
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-5-8"),
                        Doctor = "Davis, Everette",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Hemoglobin / Hematocrit / Platelet count",
                        Location = "Dr. Gino Mercadante  P.C.",
                        Created = DateTime.Parse("2019-3-8"),
                        CreatedBy = "Douglas, Marge",
                        Modified = DateTime.Parse("2019-7-3"),
                        ModifiedBy = "Leffler, Latia",
                        PatientId = 28
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-5-30"),
                        Doctor = "Goldner, Alvin",
                        ReferralDoctor = "McLaughlin, Angle",
                        Procedure = "Screening mammography (procedure)",
                        Location = "Alain A. Chaoui Md Pc",
                        Created = DateTime.Parse("2019-3-5"),
                        CreatedBy = "Marvin, Tanner",
                        Modified = DateTime.Parse("2019-5-21"),
                        ModifiedBy = "King, Buster",
                        PatientId = 62
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-1-5"),
                        Doctor = "Romaguera, Reggie",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Spontaneous breech delivery",
                        Location = "Mercy Medical Ctr",
                        Created = DateTime.Parse("2020-4-13"),
                        CreatedBy = "Grimes, Haywood",
                        Modified = DateTime.Parse("2020-5-24"),
                        ModifiedBy = "Legros, Kermit",
                        PatientId = 33
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-9"),
                        Doctor = "Mosciski, Alfonso",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Sputum examination (procedure)",
                        Location = "Odonata Psychotherapy And Retreat Center Llc",
                        Created = DateTime.Parse("2020-12-4"),
                        CreatedBy = "Russel, Rebeca",
                        Modified = DateTime.Parse("2021-1-11"),
                        ModifiedBy = "Hyatt, Ferdinand",
                        PatientId = 38
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-19"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Thiel, Damion",
                        Procedure = "Evaluation of uterine fundal height",
                        Location = "Falmouth Walk In Medical Center",
                        Created = DateTime.Parse("2019-6-30"),
                        CreatedBy = "Goldner, Jenell",
                        Modified = DateTime.Parse("2019-9-9"),
                        ModifiedBy = "Sporer, Wilfred",
                        PatientId = 66
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-12-14"),
                        Doctor = "Sawayn, Luna",
                        ReferralDoctor = "Goyette, Anissa",
                        Procedure = "Intubation",
                        Location = "Weston Primary Care  Pc",
                        Created = DateTime.Parse("2019-7-18"),
                        CreatedBy = "Gerlach, Jarrett",
                        Modified = DateTime.Parse("2019-9-5"),
                        ModifiedBy = "Delra�o, Cecilia",
                        PatientId = 18
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-1-19"),
                        Doctor = "Watsica, Lory",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
                        Location = "Orthopedic And Sports Physical Therapy Of Cape Cod Llc",
                        Created = DateTime.Parse("2019-5-14"),
                        CreatedBy = "O'Keefe, Adolfo",
                        Modified = DateTime.Parse("2019-8-18"),
                        ModifiedBy = "Gusikowski, Lavern",
                        PatientId = 84
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-9"),
                        Doctor = "Rau, Tereasa",
                        ReferralDoctor = "Goldner, Alvin",
                        Procedure = "Ultrasound scan for fetal viability",
                        Location = "Walk In And Primary Care",
                        Created = DateTime.Parse("2019-7-27"),
                        CreatedBy = "Mosciski, Alfonso",
                        Modified = DateTime.Parse("2019-11-4"),
                        ModifiedBy = "Crist, Alpha",
                        PatientId = 23
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-9-21"),
                        Doctor = "Lesch, Walton",
                        ReferralDoctor = "Goyette, Anissa",
                        Procedure = "Vaccination for diphtheria  pertussis  and tetanus",
                        Location = "Ent Specialists  Inc",
                        Created = DateTime.Parse("2020-6-23"),
                        CreatedBy = "Medhurst, Les",
                        Modified = DateTime.Parse("2020-9-15"),
                        ModifiedBy = "Murray, Rupert",
                        PatientId = 62
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-1"),
                        Doctor = "McLaughlin, Angle",
                        ReferralDoctor = "Kunze, Morton",
                        Procedure = "Spontaneous breech delivery",
                        Location = "Urgent Care Specialists Pc",
                        Created = DateTime.Parse("2019-2-21"),
                        CreatedBy = "Windler, Brady",
                        Modified = DateTime.Parse("2019-5-4"),
                        ModifiedBy = "Hammes, Emory",
                        PatientId = 97
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-6-2"),
                        Doctor = "Goyette, Anissa",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Admission to long stay hospital",
                        Location = "The Mclean Hospital Corporation",
                        Created = DateTime.Parse("2019-5-17"),
                        CreatedBy = "Torphy, Emely",
                        Modified = DateTime.Parse("2019-9-3"),
                        ModifiedBy = "Metz, Fred",
                        PatientId = 98
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-3-12"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Kreiger, Leo",
                        Procedure = "Asthma screening",
                        Location = "Noble Hospital",
                        Created = DateTime.Parse("2020-10-2"),
                        CreatedBy = "Grimes, Andre",
                        Modified = DateTime.Parse("2020-11-5"),
                        ModifiedBy = "Marquardt, Ezequiel",
                        PatientId = 94
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-12-26"),
                        Doctor = "Fadel, Steven",
                        ReferralDoctor = "Mosciski, Alfonso",
                        Procedure = "Blood typing  RH typing",
                        Location = "Community Physicians Assoc Inc",
                        Created = DateTime.Parse("2019-4-29"),
                        CreatedBy = "Ankunding, Jimmy",
                        Modified = DateTime.Parse("2019-8-9"),
                        ModifiedBy = "Heaney, Michel",
                        PatientId = 61
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-12-13"),
                        Doctor = "Trejo, Susana",
                        ReferralDoctor = "Trejo, Susana",
                        Procedure = "Urine protein test",
                        Location = "Rcna1 Pllc",
                        Created = DateTime.Parse("2019-3-11"),
                        CreatedBy = "Stanton, Christen",
                        Modified = DateTime.Parse("2019-5-2"),
                        ModifiedBy = "Caraballo, Gerardo",
                        PatientId = 3
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-9-19"),
                        Doctor = "Sawayn, Luna",
                        ReferralDoctor = "McLaughlin, Angle",
                        Procedure = "Alpha-fetoprotein test",
                        Location = "Gateway Physical Therapy And Wellness Corp",
                        Created = DateTime.Parse("2020-12-17"),
                        CreatedBy = "Hauck, Rebecka",
                        Modified = DateTime.Parse("2021-3-5"),
                        ModifiedBy = "Larson, Georgie",
                        PatientId = 51
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-2-5"),
                        Doctor = "Thiel, Damion",
                        ReferralDoctor = "Mosciski, Alfonso",
                        Procedure = "Auscultation of the fetal heart",
                        Location = "Jump Start Physical Therapy  Inc",
                        Created = DateTime.Parse("2020-3-15"),
                        CreatedBy = "Monroy, Leonor",
                        Modified = DateTime.Parse("2020-6-4"),
                        ModifiedBy = "Dach, Robbi",
                        PatientId = 96
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-13"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Watsica, Lory",
                        Procedure = "Chest X-ray",
                        Location = "Concentra Urgent Care - Springfield",
                        Created = DateTime.Parse("2020-12-4"),
                        CreatedBy = "Schneider, Gwendolyn",
                        Modified = DateTime.Parse("2021-1-17"),
                        ModifiedBy = "Dickens, Daina",
                        PatientId = 38
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-24"),
                        Doctor = "Berge, Ranae",
                        ReferralDoctor = "Mills, Nigel",
                        Procedure = "Suicide risk assessment (procedure)",
                        Location = "Milford Regional Medical Center",
                        Created = DateTime.Parse("2020-2-23"),
                        CreatedBy = "Montaato, Caridad",
                        Modified = DateTime.Parse("2020-4-30"),
                        ModifiedBy = "Hermann, Christoper",
                        PatientId = 94
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-11-26"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Goldner, Alvin",
                        Procedure = "Rubella screening",
                        Location = "General Health Care",
                        Created = DateTime.Parse("2020-9-10"),
                        CreatedBy = "Fisher, Karren",
                        Modified = DateTime.Parse("2020-12-30"),
                        ModifiedBy = "Carter, Williams",
                        PatientId = 14
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-12-18"),
                        Doctor = "Hegmann, Myrl",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "negative screening for depression on phq9",
                        Location = "new England Inpatient Specialist Llc",
                        Created = DateTime.Parse("2019-10-31"),
                        CreatedBy = "Hettinger, Youlanda",
                        Modified = DateTime.Parse("2020-1-18"),
                        ModifiedBy = "Lemke, Theda",
                        PatientId = 87
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-11-2"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Gerhold, Joline",
                        Procedure = "High resolution computed tomography of chest without contrast (procedure)",
                        Location = "First Choice Community Medical Services Pc",
                        Created = DateTime.Parse("2020-5-24"),
                        CreatedBy = "Hilll, Harold",
                        Modified = DateTime.Parse("2020-9-17"),
                        ModifiedBy = "Durgan, Christeen",
                        PatientId = 94
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-9-17"),
                        Doctor = "Romaguera, Reggie",
                        ReferralDoctor = "Mills, Nigel",
                        Procedure = "Transthoracic three dimensional ultrasonography of heart (procedure)",
                        Location = "Shriners' Hospital For Children (The)",
                        Created = DateTime.Parse("2020-6-26"),
                        CreatedBy = "Quigley, David",
                        Modified = DateTime.Parse("2020-8-2"),
                        ModifiedBy = "Abernathy, Renee",
                        PatientId = 74
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-23"),
                        Doctor = "Kulas, Asha",
                        ReferralDoctor = "Bode, Daniel",
                        Procedure = "Injection of tetanus antitoxin",
                        Location = "Fairview Hospital",
                        Created = DateTime.Parse("2019-6-17"),
                        CreatedBy = "Reinger, Vanessa",
                        Modified = DateTime.Parse("2019-10-5"),
                        ModifiedBy = "Villa, Alejandra",
                        PatientId = 11
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-9-10"),
                        Doctor = "Gurule, Eugenia",
                        ReferralDoctor = "DuBuque, Norris",
                        Procedure = "Transthoracic echocardiography",
                        Location = "Steward St. Elizabeth'S Medical Center Of Boston  Inc.",
                        Created = DateTime.Parse("2019-11-25"),
                        CreatedBy = "Jacobi, Micheal",
                        Modified = DateTime.Parse("2020-3-7"),
                        ModifiedBy = "Effertz, Donnetta",
                        PatientId = 84
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-1-29"),
                        Doctor = "Goyette, Anissa",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "Echocardiography (procedure)",
                        Location = "Urology Consultants Of Ns",
                        Created = DateTime.Parse("2020-8-20"),
                        CreatedBy = "Turner, Hye",
                        Modified = DateTime.Parse("2020-9-29"),
                        ModifiedBy = "Prohaska, Ezra",
                        PatientId = 66
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-11-22"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "X-ray or wrist",
                        Location = "Khoury Chiropractc  Inc.",
                        Created = DateTime.Parse("2019-4-19"),
                        CreatedBy = "Predovic, Lilian",
                        Modified = DateTime.Parse("2019-7-9"),
                        ModifiedBy = "Metz, Mel",
                        PatientId = 76
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-6-16"),
                        Doctor = "Rolfson, Nelia",
                        ReferralDoctor = "Gurule, Eugenia",
                        Procedure = "Electrical cardioversion",
                        Location = "Paggi Physical Therapy And Sports Rehabilitation  Inc",
                        Created = DateTime.Parse("2020-8-28"),
                        CreatedBy = "Ratke, Janella",
                        Modified = DateTime.Parse("2020-11-10"),
                        ModifiedBy = "Quigley, Mitchel",
                        PatientId = 12
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-8-16"),
                        Doctor = "Mosciski, Alfonso",
                        ReferralDoctor = "Gurule, Eugenia",
                        Procedure = "Pulmonary rehabilitation (regime/therapy)",
                        Location = "Gateway Physical Therapy And Wellness Corp",
                        Created = DateTime.Parse("2019-3-1"),
                        CreatedBy = "Kuvalis, Hershel",
                        Modified = DateTime.Parse("2019-5-29"),
                        ModifiedBy = "Lind, Roselia",
                        PatientId = 20
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-11-30"),
                        Doctor = "Kreiger, Leo",
                        ReferralDoctor = "Goldner, Alvin",
                        Procedure = "Catheter ablation of tissue of heart",
                        Location = "Personal Best Physical Therapy Llc",
                        Created = DateTime.Parse("2020-7-2"),
                        CreatedBy = "Weber, Janean",
                        Modified = DateTime.Parse("2020-9-7"),
                        ModifiedBy = "Cremin, Shelby",
                        PatientId = 90
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-29"),
                        Doctor = "Mills, Nigel",
                        ReferralDoctor = "Hegmann, Myrl",
                        Procedure = "negative screening for depression on phq9",
                        Location = "Total Wellness Centers  Llc",
                        Created = DateTime.Parse("2020-7-13"),
                        CreatedBy = "Turcotte, Thanh",
                        Modified = DateTime.Parse("2020-9-11"),
                        ModifiedBy = "Kris, Victor",
                        PatientId = 66
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-5-17"),
                        Doctor = "Goyette, Anissa",
                        ReferralDoctor = "Watsica, Lory",
                        Procedure = "Fecal occult blood test",
                        Location = "Lahey Hospital & Medical Center  Burlington",
                        Created = DateTime.Parse("2019-12-29"),
                        CreatedBy = "Bruen, Teri",
                        Modified = DateTime.Parse("2020-2-4"),
                        ModifiedBy = "Casillas, Yolanda",
                        PatientId = 20
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-14"),
                        Doctor = "Romaguera, Reggie",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Manual pelvic examination (procedure)",
                        Location = "The Mclean Hospital Corporation",
                        Created = DateTime.Parse("2019-12-23"),
                        CreatedBy = "Wilkinson, Samella",
                        Modified = DateTime.Parse("2020-2-15"),
                        ModifiedBy = "Volkman, Carmelo",
                        PatientId = 24
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-1-28"),
                        Doctor = "Thiel, Damion",
                        ReferralDoctor = "Paredes, Ana",
                        Procedure = "Depression screening",
                        Location = "Saperia Orthopaedics And Sports Medicine Inc",
                        Created = DateTime.Parse("2020-7-15"),
                        CreatedBy = "Hidalgo, Elisa",
                        Modified = DateTime.Parse("2020-8-24"),
                        ModifiedBy = "Von, Vernie",
                        PatientId = 93
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-10-14"),
                        Doctor = "Corwin, Shelly",
                        ReferralDoctor = "Paredes, Ana",
                        Procedure = "Seizure Count Cerebral Cortex Electroencephalogram (EEG)",
                        Location = "Merrimack Valley Oral Surgeons  Inc",
                        Created = DateTime.Parse("2019-3-13"),
                        CreatedBy = "Heidenreich, Porter",
                        Modified = DateTime.Parse("2019-6-17"),
                        ModifiedBy = "Hyatt, Ferdinand",
                        PatientId = 47
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-12-24"),
                        Doctor = "Goldner, Alvin",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "Episiotomy",
                        Location = "Family Medical Center",
                        Created = DateTime.Parse("2019-6-22"),
                        CreatedBy = "Reichel, Billy",
                        Modified = DateTime.Parse("2019-10-9"),
                        ModifiedBy = "Bergnaum, Magan",
                        PatientId = 94
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-2-17"),
                        Doctor = "DuBuque, Norris",
                        ReferralDoctor = "Berge, Ranae",
                        Procedure = "Screening mammography (procedure)",
                        Location = "Barry S Paul  M.D.",
                        Created = DateTime.Parse("2019-6-9"),
                        CreatedBy = "Bahena, Lucia",
                        Modified = DateTime.Parse("2019-7-25"),
                        ModifiedBy = "Guillen, David",
                        PatientId = 67
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-1-9"),
                        Doctor = "Thiel, Damion",
                        ReferralDoctor = "Goldner, Alvin",
                        Procedure = "Construction of diverting colostomy",
                        Location = "Advance Orthopedic And Sports Therapy",
                        Created = DateTime.Parse("2020-4-5"),
                        CreatedBy = "Cole, Clifford",
                        Modified = DateTime.Parse("2020-5-23"),
                        ModifiedBy = "Purdy, Emmanuel",
                        PatientId = 27
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-14"),
                        Doctor = "Zboncak, Shavonne",
                        ReferralDoctor = "Fadel, Steven",
                        Procedure = "Digital examination of rectum",
                        Location = "East Boston Neighborhood Health Center Urgent Care",
                        Created = DateTime.Parse("2020-10-9"),
                        CreatedBy = "Considine, Pat",
                        Modified = DateTime.Parse("2020-12-9"),
                        ModifiedBy = "Corkery, Vance",
                        PatientId = 78
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-1-17"),
                        Doctor = "Sawayn, Luna",
                        ReferralDoctor = "Kulas, Asha",
                        Procedure = "Nasal sinus endoscopy (procedure)",
                        Location = "Bridgewell  Inc",
                        Created = DateTime.Parse("2019-9-18"),
                        CreatedBy = "Hintz, Nohemi",
                        Modified = DateTime.Parse("2019-10-25"),
                        ModifiedBy = "Corral, Cristina",
                        PatientId = 85
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-3"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Rolfson, Nelia",
                        Procedure = "Appendectomy",
                        Location = "Comprehensive Health Services Llc",
                        Created = DateTime.Parse("2019-6-16"),
                        CreatedBy = "Anderson, Ellis",
                        Modified = DateTime.Parse("2019-9-9"),
                        ModifiedBy = "Ruecker, Shavonda",
                        PatientId = 70
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-5-6"),
                        Doctor = "Gerhold, Joline",
                        ReferralDoctor = "Paredes, Ana",
                        Procedure = "Auscultation of the fetal heart",
                        Location = "Adcare Hospital Of Worcester Inc",
                        Created = DateTime.Parse("2020-6-17"),
                        CreatedBy = "Bahringer, Wynona",
                        Modified = DateTime.Parse("2020-7-18"),
                        ModifiedBy = "Morissette, Alvera",
                        PatientId = 97
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-4-18"),
                        Doctor = "Bode, Daniel",
                        ReferralDoctor = "Gerhold, Joline",
                        Procedure = "Review of systems (procedure)",
                        Location = "Massbay Counseling Inc.",
                        Created = DateTime.Parse("2020-3-8"),
                        CreatedBy = "Williamson, Jose",
                        Modified = DateTime.Parse("2020-5-12"),
                        ModifiedBy = "Marvin, Alfred",
                        PatientId = 14
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-5-5"),
                        Doctor = "Friesen, Mariano",
                        ReferralDoctor = "Lesch, Walton",
                        Procedure = "Transthoracic echocardiography",
                        Location = "Winchester Lahey Inpatient Specialists Pllc",
                        Created = DateTime.Parse("2020-10-6"),
                        CreatedBy = "Keeling, Chandra",
                        Modified = DateTime.Parse("2021-1-25"),
                        ModifiedBy = "Wunsch, Melinda",
                        PatientId = 70
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-17"),
                        Doctor = "Fadel, Steven",
                        ReferralDoctor = "Rau, Tereasa",
                        Procedure = "Ultrasonography of bilateral breasts (procedure)",
                        Location = "St Vincent Hospital",
                        Created = DateTime.Parse("2019-10-7"),
                        CreatedBy = "Bode, Leland",
                        Modified = DateTime.Parse("2019-12-25"),
                        ModifiedBy = "Dooley, Ryan",
                        PatientId = 9
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-21"),
                        Doctor = "McLaughlin, Angle",
                        ReferralDoctor = "Thiel, Damion",
                        Procedure = "Human epidermal growth factor receptor 2 gene detection by fluorescence in situ hybridization (procedure)",
                        Location = "Harvard Medical Faculty Phys At Beth Israel Deaconess Med Ctr  Inc.",
                        Created = DateTime.Parse("2019-2-23"),
                        CreatedBy = "Mitchell, Gerard",
                        Modified = DateTime.Parse("2019-6-16"),
                        ModifiedBy = "Corkery, Waldo",
                        PatientId = 31
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-3"),
                        Doctor = "Watsica, Lory",
                        ReferralDoctor = "Kulas, Asha",
                        Procedure = "Screening mammography (procedure)",
                        Location = "Berkshire Medical Center Inc - 1",
                        Created = DateTime.Parse("2020-7-5"),
                        CreatedBy = "Corwin, Shelly",
                        Modified = DateTime.Parse("2020-9-1"),
                        ModifiedBy = "Cronin, Adam",
                        PatientId = 20
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-7-31"),
                        Doctor = "DuBuque, Norris",
                        ReferralDoctor = "Trejo, Susana",
                        Procedure = "Transthoracic echocardiography",
                        Location = "Prima Care / Somerset Swansea Walk In Care Center",
                        Created = DateTime.Parse("2020-5-16"),
                        CreatedBy = "Predovic, Gigi",
                        Modified = DateTime.Parse("2020-9-13"),
                        ModifiedBy = "Kub, Tomasa",
                        PatientId = 49
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-12"),
                        Doctor = "Zboncak, Shavonne",
                        ReferralDoctor = "Ondricka, Bradley",
                        Procedure = "Methotrexate injection into tubal pregnancy",
                        Location = "Paggi Physical Therapy And Sports Rehabilitation  Inc",
                        Created = DateTime.Parse("2019-10-30"),
                        CreatedBy = "Crist, Erwin",
                        Modified = DateTime.Parse("2019-12-16"),
                        ModifiedBy = "Harber, Amalia",
                        PatientId = 54
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-10"),
                        Doctor = "Lesch, Walton",
                        ReferralDoctor = "Emard, Denisse",
                        Procedure = "Hepatitis C antibody test",
                        Location = "Clinical And Support Options  Inc",
                        Created = DateTime.Parse("2019-11-21"),
                        CreatedBy = "Lind, Michel",
                        Modified = DateTime.Parse("2020-3-7"),
                        ModifiedBy = "Auer, Sherita",
                        PatientId = 95
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-2-4"),
                        Doctor = "Berge, Ranae",
                        ReferralDoctor = "Bode, Daniel",
                        Procedure = "Hepatitis C antibody test",
                        Location = "Massachusetts Eye And Ear Associates  Inc",
                        Created = DateTime.Parse("2020-9-23"),
                        CreatedBy = "Cole, Griselda",
                        Modified = DateTime.Parse("2020-12-24"),
                        ModifiedBy = "Grimes, Omega",
                        PatientId = 99
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-8-21"),
                        Doctor = "Ondricka, Bradley",
                        ReferralDoctor = "Kulas, Asha",
                        Procedure = "Percutaneous coronary intervention",
                        Location = "Allergy Affiliates Of Danvers",
                        Created = DateTime.Parse("2019-9-23"),
                        CreatedBy = "Ondricka, Zula",
                        Modified = DateTime.Parse("2019-11-12"),
                        ModifiedBy = "Parker, Cicely",
                        PatientId = 100
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-7"),
                        Doctor = "Kunze, Morton",
                        ReferralDoctor = "Ondricka, Bradley",
                        Procedure = "Episiotomy",
                        Location = "Guardian Brockton Pc",
                        Created = DateTime.Parse("2019-4-24"),
                        CreatedBy = "Howe, Hazel",
                        Modified = DateTime.Parse("2019-7-25"),
                        ModifiedBy = "Hackett, Mariette",
                        PatientId = 99
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-3-18"),
                        Doctor = "Thiel, Damion",
                        ReferralDoctor = "Romaguera, Reggie",
                        Procedure = "Manual pelvic examination (procedure)",
                        Location = "Eye Exams  Llc",
                        Created = DateTime.Parse("2019-5-1"),
                        CreatedBy = "Nolan, Kanisha",
                        Modified = DateTime.Parse("2019-6-23"),
                        ModifiedBy = "Kuhlman, Demarcus",
                        PatientId = 61
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-8-17"),
                        Doctor = "Trejo, Susana",
                        ReferralDoctor = "Kulas, Asha",
                        Procedure = "Excision of sentinel lymph node (procedure)",
                        Location = "Metrowest Oral Surgical Associates",
                        Created = DateTime.Parse("2019-7-15"),
                        CreatedBy = "Cummings, Rashad",
                        Modified = DateTime.Parse("2019-8-19"),
                        ModifiedBy = "Frami, Noble",
                        PatientId = 57
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-6-29"),
                        Doctor = "Ondricka, Bradley",
                        ReferralDoctor = "Goldner, Alvin",
                        Procedure = "Blood typing  RH typing",
                        Location = "Prima Care / Somerset Swansea Walk In Care Center",
                        Created = DateTime.Parse("2019-7-8"),
                        CreatedBy = "Grant, Vernie",
                        Modified = DateTime.Parse("2019-8-16"),
                        ModifiedBy = "Lemke, Lorinda",
                        PatientId = 36
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-4-18"),
                        Doctor = "Gurule, Eugenia",
                        ReferralDoctor = "Goyette, Anissa",
                        Procedure = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
                        Location = "Valley Podiatry Associates Pc",
                        Created = DateTime.Parse("2020-3-12"),
                        CreatedBy = "Turner, Ariel",
                        Modified = DateTime.Parse("2020-4-29"),
                        ModifiedBy = "Kessler, Elba",
                        PatientId = 53
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-10-18"),
                        Doctor = "Bode, Daniel",
                        ReferralDoctor = "Mills, Nigel",
                        Procedure = "Mammogram - symptomatic (procedure)",
                        Location = "Hampden County Urgent Medical Care Center",
                        Created = DateTime.Parse("2020-11-12"),
                        CreatedBy = "Dooley, Renae",
                        Modified = DateTime.Parse("2021-3-10"),
                        ModifiedBy = "Daniel, John",
                        PatientId = 13
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-18"),
                        Doctor = "Romaguera, Reggie",
                        ReferralDoctor = "Trejo, Susana",
                        Procedure = "Appendectomy",
                        Location = "Lowell General Hospital",
                        Created = DateTime.Parse("2019-4-25"),
                        CreatedBy = "Schumm, Buffy",
                        Modified = DateTime.Parse("2019-7-10"),
                        ModifiedBy = "Tillman, Tyron",
                        PatientId = 31
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-9-24"),
                        Doctor = "DuBuque, Norris",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "Insertion of intrauterine contraceptive device",
                        Location = "Baystate Wing Hospital And Medical Centers",
                        Created = DateTime.Parse("2019-4-7"),
                        CreatedBy = "Klein, Ross",
                        Modified = DateTime.Parse("2019-5-30"),
                        ModifiedBy = "Berge, Dorris",
                        PatientId = 18
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-8-13"),
                        Doctor = "Emard, Denisse",
                        ReferralDoctor = "Davis, Everette",
                        Procedure = "Medication Reconciliation (procedure)",
                        Location = "Mercy Medical Group Inc",
                        Created = DateTime.Parse("2019-9-10"),
                        CreatedBy = "Mills, Kevin",
                        Modified = DateTime.Parse("2020-1-1"),
                        ModifiedBy = "Rolfson, Nelia",
                        PatientId = 26
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-11-29"),
                        Doctor = "Berge, Ranae",
                        ReferralDoctor = "Heathcote, Wilson",
                        Procedure = "Physical examination of mother",
                        Location = "Advanced Audiology Associates Inc",
                        Created = DateTime.Parse("2019-2-10"),
                        CreatedBy = "Hirthe, Rochell",
                        Modified = DateTime.Parse("2019-3-23"),
                        ModifiedBy = "Block, Penni",
                        PatientId = 81
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2019-7-17"),
                        Doctor = "Friesen, Mariano",
                        ReferralDoctor = "Rolfson, Nelia",
                        Procedure = "Cognitive and behavioral therapy",
                        Location = "Dr. Gino Mercadante  P.C.",
                        Created = DateTime.Parse("2020-9-28"),
                        CreatedBy = "Koch, Chung",
                        Modified = DateTime.Parse("2020-11-2"),
                        ModifiedBy = "Moen, Jacquelin",
                        PatientId = 52
                        },
                    new Referral
                        {
                        ReferralDate = DateTime.Parse("2020-5-19"),
                        Doctor = "Paredes, Ana",
                        ReferralDoctor = "Bode, Daniel",
                        Procedure = "Construction of diverting colostomy",
                        Location = "Causeway Opc",
                        Created = DateTime.Parse("2020-8-25"),
                        CreatedBy = "Quigley, David",
                        Modified = DateTime.Parse("2020-10-6"),
                        ModifiedBy = "Medhurst, Les",
                        PatientId = 6
                        }
                };
            referrals.ForEach(r => context.Referrals.Add(r));
            context.SaveChanges();

            var providers = new List<Provider>
            {
                new Provider
                {
                    ProviderName = "Laura Ferrer",
                    Specialty = "Podiatry"
                },
                new Provider
                {
                    ProviderName = "Ivan Koelpin",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Aundrea Cronin",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Adina Tromp",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Adriana Anguiano",
                    Specialty = "Psychiatry"
                },
                new Provider
                {
                    ProviderName = "Adriane Stark",
                    Specialty = "Optometry"
                },
                new Provider
                {
                    ProviderName = "Seth Kuvalis",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Brandie Wehner",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Jonah Watsica",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Anastacia Waelchi",
                    Specialty = "Psychiatry"
                },
                new Provider
                {
                    ProviderName = "Roberto Montoya",
                    Specialty = "Diagnostic Radiology"
                },
                new Provider
                {
                    ProviderName = "Hershel Jakubowski",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Cristian Alfaro",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Cary Marquardt",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Season Bins",
                    Specialty = "Allergy/Immunology"
                },
                new Provider
                {
                    ProviderName = "Delmer Crist",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Jonah Hammes",
                    Specialty = "Certified Registered Nurse Anesthetist"
                },
                new Provider
                {
                    ProviderName = "Kasey Tromp",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Nidia Brekke",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Stephany Sanford",
                    Specialty = "Diagnostic Radiology"
                },
                new Provider
                {
                    ProviderName = "Dexter Weissnat",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Tomeka Feest",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Donnetta Kling",
                    Specialty = "Anesthesiology"
                },
                new Provider
                {
                    ProviderName = "Randell Hodkiewicz",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Rosette Bernhard",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Roy Schowalter",
                    Specialty = "Ophthalmology"
                },
                new Provider
                {
                    ProviderName = "Codi Bahringer",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Guillermina Acua�a",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Zina Ondricka",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Floria Leffler",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Toma�s Tirado",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Evangeline Goldner",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Charity Ebert",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Tennie Kling",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Latrina McDermott",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Ewa Hackett",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Josae Mara�a Laureano",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Daren Glover",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Chantell Murray",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Clyde Fahey",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Jules Rogahn",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Craig Corkery",
                    Specialty = "Chiropractic"
                },
                new Provider
                {
                    ProviderName = "Brianna Hartmann",
                    Specialty = "Optometry"
                },
                new Provider
                {
                    ProviderName = "Lane Watsica",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Gwendolyn Rice",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Caroline Hintz",
                    Specialty = "Sports Medicine"
                },
                new Provider
                {
                    ProviderName = "Evelyn Bechtelar",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Doyle Fritsch",
                    Specialty = "Neurology"
                },
                new Provider
                {
                    ProviderName = "Agatha Windler",
                    Specialty = "Psychiatry"
                },
                new Provider
                {
                    ProviderName = "Delinda Hilpert",
                    Specialty = "Diagnostic Radiology"
                },
                new Provider
                {
                    ProviderName = "Astrid McGlynn",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Tim Stokes",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Leslie Lynch",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Rupert Gislason",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Elyse Weimann",
                    Specialty = "Clinical Psychologist"
                },
                new Provider
                {
                    ProviderName = "Merrilee Kreiger",
                    Specialty = "Emergency Medicine"
                },
                new Provider
                {
                    ProviderName = "Cameron Waelchi",
                    Specialty = "Audiologist"
                },
                new Provider
                {
                    ProviderName = "Johnathon Moen",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Harold Ernser",
                    Specialty = "Chiropractic"
                },
                new Provider
                {
                    ProviderName = "Quentin Heidenreich",
                    Specialty = "Ophthalmology"
                },
                new Provider
                {
                    ProviderName = "Nicolasa Koepp",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Euna Robel",
                    Specialty = "Optometry"
                },
                new Provider
                {
                    ProviderName = "Eun Ward",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Oren Hagenes",
                    Specialty = "Physician Assistant"
                },
                new Provider
                {
                    ProviderName = "Anita Montes",
                    Specialty = "Optometry"
                },
                new Provider
                {
                    ProviderName = "Claudia Romero",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Irene Carmona",
                    Specialty = "Psychiatry"
                },
                new Provider
                {
                    ProviderName = "Rosalind Turcotte",
                    Specialty = "Psychiatry"
                },
                new Provider
                {
                    ProviderName = "Brianna Hartmann",
                    Specialty = "Optometry"
                },
                new Provider
                {
                    ProviderName = "Stuart Jones",
                    Specialty = "Certified Nurse Midwife"
                },
                new Provider
                {
                    ProviderName = "Darius Stiedemann",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Inocencia Medhurst",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Terrence Schmeler",
                    Specialty = "Nephrology"
                },
                new Provider
                {
                    ProviderName = "Else Cole",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Lucius Corkery",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Carlita Mueller",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Dusti Lindgren",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Alana Lockman",
                    Specialty = "Physician Assistant"
                },
                new Provider
                {
                    ProviderName = "Sulema Auer",
                    Specialty = "Podiatry"
                },
                new Provider
                {
                    ProviderName = "Maricarmen Arteaga",
                    Specialty = "Chiropractic"
                },
                new Provider
                {
                    ProviderName = "Greg Lind",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Gerald Funk",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Kattie Wisozk",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Joette Schaefer",
                    Specialty = "Nurse Practitioner"
                },
                new Provider
                {
                    ProviderName = "Vanita Wyman",
                    Specialty = "Family Practice"
                },
                new Provider
                {
                    ProviderName = "Eva Reilly",
                    Specialty = "Physical Therapy"
                },
                new Provider
                {
                    ProviderName = "Jorge Herna�ndez",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Lisa Weber",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Ronny Blick",
                    Specialty = "Clinical Psychologist"
                },
                new Provider
                {
                    ProviderName = "Raven Kiehn",
                    Specialty = "Neurology"
                },
                new Provider
                {
                    ProviderName = "Ted Padberg",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Carlie Gleason",
                    Specialty = "Internal Medicine"
                },
                new Provider
                {
                    ProviderName = "Jolyn Bechtelar",
                    Specialty = "Chiropractic"
                },
                new Provider
                {
                    ProviderName = "Harriett Hodkiewicz",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Carmen Kreiger",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Charles Simonis",
                    Specialty = "Physician Assistant"
                },
                new Provider
                {
                    ProviderName = "Earnest Gleichner",
                    Specialty = "General Practice"
                },
                new Provider
                {
                    ProviderName = "Mara�a Luisa Toledo",
                    Specialty = "Podiatry"
                },
                new Provider
                {
                    ProviderName = "Wen Stanton",
                    Specialty = "Clinical Social Worker"
                },
                new Provider
                {
                    ProviderName = "Andrea Herna�ndez",
                    Specialty = "Internal Medicine"
                }
            };
            providers.ForEach(p => context.Providers.Add(p));
            context.SaveChanges();


            }
        }
    }
