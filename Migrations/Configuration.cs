namespace PatientPortalApp.Migrations
	{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using PatientPortalApp.Models;
	using System.Collections.Generic;

	internal sealed class Configuration : DbMigrationsConfiguration<PatientPortalApp.Data.PatientPortalAppContext>
		{
		public Configuration()
			{
			AutomaticMigrationsEnabled = false;
			}

		protected override void Seed(PatientPortalApp.Data.PatientPortalAppContext context)
			{
			if (context.Patients.Any())
				{
				return;
				}
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
						LastName = "Ura?as",
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
						FirstName = "Herna?n",
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
			patients.ForEach(p => context.Patients.AddOrUpdate(p));
			context.SaveChanges();

			if (context.Referrals.Any())
				{
				return;
				}

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
						ModifiedBy = "Esta?vez, Luis Miguel",
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
						CreatedBy = "Zambrano, Da?bora",
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
						CreatedBy = "Rodra?guez, Ernesto",
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
						ModifiedBy = "Delra?o, Cecilia",
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
			referrals.ForEach(r => context.Referrals.AddOrUpdate(r));
			context.SaveChanges();

			if (context.Providers.Any())
				{
				return;
				}

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
					ProviderName = "Guillermina Acua?a",
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
					ProviderName = "Toma?s Tirado",
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
					ProviderName = "Josae Mara?a Laureano",
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
					ProviderName = "Jorge Herna?ndez",
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
					ProviderName = "Mara?a Luisa Toledo",
					Specialty = "Podiatry"
				},
				new Provider
				{
					ProviderName = "Wen Stanton",
					Specialty = "Clinical Social Worker"
				},
				new Provider
				{
					ProviderName = "Andrea Herna?ndez",
					Specialty = "Internal Medicine"
				}
			};
			providers.ForEach(p => context.Providers.AddOrUpdate(p));
			context.SaveChanges();

			if (context.Appoinments.Any())
				{
				return;
				}

			var appointments = new List<Appointment>
				{
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-26-2019 11:50:27 AM"),
						Created = DateTime.Parse("7-12-2019 2:58:15 PM"),
						Modified = DateTime.Parse("9-21-2019 11:10:11 AM"),
						CreatedBy = "Williams Bosco",
						ModifiedBy = "Mckinley Ratke",
						Reason = "Bleeding from anus",
						PatientId = 1,
						ProviderId = 1
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-26-2019 9:45:55 AM"),
						Created = DateTime.Parse("8-13-2019 1:34:40 PM"),
						Modified = DateTime.Parse("11-11-2019 1:06:26 PM"),
						CreatedBy = "Irvin Labadie",
						ModifiedBy = "Reanna Bernhard",
						Reason = "Neuropathy due to type 2 diabetes mellitus (disorder)",
						PatientId = 2,
						ProviderId = 2
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("1-31-2019 10:48:34 AM"),
						Created = DateTime.Parse("4-22-2019 2:04:50 PM"),
						Modified = DateTime.Parse("7-24-2019 9:54:39 AM"),
						CreatedBy = "Virgilio Swift",
						ModifiedBy = "Luther Ondricka",
						Reason = "Primary fibromyalgia syndrome",
						PatientId = 3,
						ProviderId = 3
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-23-2019 9:24:08 AM"),
						Created = DateTime.Parse("5-7-2019 11:10:11 AM"),
						Modified = DateTime.Parse("8-25-2019 5:14:24 PM"),
						CreatedBy = "Angeline Doyle",
						ModifiedBy = "Carlita Gutkowski",
						Reason = "Anemia (disorder)",
						PatientId = 4,
						ProviderId = 4
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-21-2019 8:02:29 AM"),
						Created = DateTime.Parse("9-16-2019 3:09:07 PM"),
						Modified = DateTime.Parse("10-16-2019 3:32:59 PM"),
						CreatedBy = "Veola Bauch",
						ModifiedBy = "Tuan Skiles",
						Reason = "Asthma",
						PatientId = 5,
						ProviderId = 5
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-29-2020 2:33:18 PM"),
						Created = DateTime.Parse("6-8-2020 10:29:01 AM"),
						Modified = DateTime.Parse("9-15-2020 10:27:50 AM"),
						CreatedBy = "Raven Kiehn",
						ModifiedBy = "Bonnie Braun",
						Reason = "Fracture of forearm",
						PatientId = 6,
						ProviderId = 6
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-15-2020 2:33:49 PM"),
						Created = DateTime.Parse("8-1-2020 11:19:40 AM"),
						Modified = DateTime.Parse("10-12-2020 4:38:53 PM"),
						CreatedBy = "Alton Gerlach",
						ModifiedBy = "Marlon Heaney",
						Reason = "Acute viral pharyngitis (disorder)",
						PatientId = 7,
						ProviderId = 7
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-22-2019 11:18:50 AM"),
						Created = DateTime.Parse("1-25-2020 10:07:00 AM"),
						Modified = DateTime.Parse("5-21-2020 3:43:25 PM"),
						CreatedBy = "Benjama?n Pagan",
						ModifiedBy = "Maribel Goodwin",
						Reason = "Rupture of patellar tendon",
						PatientId = 8,
						ProviderId = 8
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-2-2019 2:33:49 PM"),
						Created = DateTime.Parse("10-1-2019 11:18:50 AM"),
						Modified = DateTime.Parse("11-22-2019 8:49:37 AM"),
						CreatedBy = "Jonah Schuppe",
						ModifiedBy = "Marquerite Collins",
						Reason = "Overlapping malignant neoplasm of colon",
						PatientId = 9,
						ProviderId = 9
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-8-2020 8:02:29 AM"),
						Created = DateTime.Parse("6-9-2020 3:58:31 PM"),
						Modified = DateTime.Parse("7-19-2020 2:29:08 PM"),
						CreatedBy = "Romelia Adams",
						ModifiedBy = "Ernesto Rodriguez",
						Reason = "Second degree burn",
						PatientId = 10,
						ProviderId = 10
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-31-2019 1:57:51 PM"),
						Created = DateTime.Parse("7-7-2019 11:19:40 AM"),
						Modified = DateTime.Parse("8-27-2019 4:10:49 PM"),
						CreatedBy = "Debrah Wunsch",
						ModifiedBy = "Adeline Hagenes",
						Reason = "Asthma",
						PatientId = 11,
						ProviderId = 11
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-22-2020 11:14:17 AM"),
						Created = DateTime.Parse("3-22-2021 8:59:04 AM"),
						Modified = DateTime.Parse("7-18-2021 5:03:04 PM"),
						CreatedBy = "Rodrick Armstrong",
						ModifiedBy = "Linwood Schultz",
						Reason = "Overlapping malignant neoplasm of colon",
						PatientId = 12,
						ProviderId = 12
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-9-2019 5:32:45 PM"),
						Created = DateTime.Parse("8-11-2019 2:40:09 PM"),
						Modified = DateTime.Parse("12-2-2019 2:22:27 PM"),
						CreatedBy = "Ramona Escobar",
						ModifiedBy = "Dana Goldner",
						Reason = "Localized  primary osteoarthritis of the hand",
						PatientId = 13,
						ProviderId = 13
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-7-2019 10:07:00 AM"),
						Created = DateTime.Parse("7-23-2019 10:07:00 AM"),
						Modified = DateTime.Parse("9-13-2019 11:44:07 AM"),
						CreatedBy = "Shawana Macejkovic",
						ModifiedBy = "Colin Yundt",
						Reason = "Fracture of forearm",
						PatientId = 14,
						ProviderId = 14
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-2-2020 5:27:16 PM"),
						Created = DateTime.Parse("12-18-2020 10:07:00 AM"),
						Modified = DateTime.Parse("4-4-2021 10:57:32 AM"),
						CreatedBy = "Angelena Reinger",
						ModifiedBy = "Claudia Ruecker",
						Reason = "Primary malignant neoplasm of colon",
						PatientId = 15,
						ProviderId = 15
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-21-2019 10:21:19 AM"),
						Created = DateTime.Parse("8-18-2019 4:06:50 PM"),
						Modified = DateTime.Parse("9-19-2019 8:19:31 AM"),
						CreatedBy = "Wendie Tromp",
						ModifiedBy = "Jan Spinka",
						Reason = "Fracture of forearm",
						PatientId = 16,
						ProviderId = 16
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-1-2020 9:55:58 AM"),
						Created = DateTime.Parse("2-17-2021 1:59:46 PM"),
						Modified = DateTime.Parse("4-1-2021 1:59:46 PM"),
						CreatedBy = "Renata Purdy",
						ModifiedBy = "Seth Kilback",
						Reason = "Posttraumatic stress disorder",
						PatientId = 17,
						ProviderId = 17
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-11-2020 5:43:28 PM"),
						Created = DateTime.Parse("8-24-2020 4:27:13 PM"),
						Modified = DateTime.Parse("11-5-2020 8:18:05 AM"),
						CreatedBy = "Heriberto Jacobson",
						ModifiedBy = "Micaela Rentera?a",
						Reason = "Injury of anterior cruciate ligament",
						PatientId = 18,
						ProviderId = 18
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-27-2019 4:26:59 PM"),
						Created = DateTime.Parse("7-15-2019 11:50:27 AM"),
						Modified = DateTime.Parse("9-19-2019 10:27:50 AM"),
						CreatedBy = "Glynis Pagac",
						ModifiedBy = "Anglea Luettgen",
						Reason = "Neuropathy due to type 2 diabetes mellitus (disorder)",
						PatientId = 19,
						ProviderId = 19
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-1-2020 10:05:27 AM"),
						Created = DateTime.Parse("5-11-2020 2:12:19 PM"),
						Modified = DateTime.Parse("6-27-2020 5:27:01 PM"),
						CreatedBy = "Margene Heller",
						ModifiedBy = "Hyman Hand",
						Reason = "Overlapping malignant neoplasm of colon",
						PatientId = 20,
						ProviderId = 20
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-22-2020 10:29:01 AM"),
						Created = DateTime.Parse("11-28-2020 3:00:13 PM"),
						Modified = DateTime.Parse("3-2-2021 1:57:51 PM"),
						CreatedBy = "Estela Delra?o",
						ModifiedBy = "Delbert Spinka",
						Reason = "Cystitis",
						PatientId = 21,
						ProviderId = 21
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-8-2019 9:25:36 AM"),
						Created = DateTime.Parse("12-17-2019 11:18:50 AM"),
						Modified = DateTime.Parse("3-14-2020 8:17:43 AM"),
						CreatedBy = "Coy Ratke",
						ModifiedBy = "Dewey Schowalter",
						Reason = "Normal pregnancy",
						PatientId = 22,
						ProviderId = 22
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-16-2019 9:32:16 AM"),
						Created = DateTime.Parse("10-14-2019 2:05:10 PM"),
						Modified = DateTime.Parse("12-20-2019 9:37:39 AM"),
						CreatedBy = "Cammy Wolff",
						ModifiedBy = "Lyle Legros",
						Reason = "Neoplasm of prostate",
						PatientId = 23,
						ProviderId = 23
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-4-2020 4:45:22 PM"),
						Created = DateTime.Parse("12-23-2020 10:38:15 AM"),
						Modified = DateTime.Parse("2-11-2021 2:15:24 PM"),
						CreatedBy = "Concetta Wiegand",
						ModifiedBy = "Abel Bogisich",
						Reason = "Third degree burn",
						PatientId = 24,
						ProviderId = 24
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-7-2019 2:58:15 PM"),
						Created = DateTime.Parse("8-22-2019 11:04:10 AM"),
						Modified = DateTime.Parse("10-11-2019 4:44:21 PM"),
						CreatedBy = "Lionel Grady",
						ModifiedBy = "Vincent MacGyver",
						Reason = "Fetus with unknown complication",
						PatientId = 25,
						ProviderId = 25
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-1-2019 10:48:34 AM"),
						Created = DateTime.Parse("10-5-2019 1:57:51 PM"),
						Modified = DateTime.Parse("12-16-2019 9:02:18 AM"),
						CreatedBy = "Sherrill Kilback",
						ModifiedBy = "Bibi Littel",
						Reason = "Chronic intractable migraine without aura",
						PatientId = 26,
						ProviderId = 26
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-22-2020 5:14:24 PM"),
						Created = DateTime.Parse("3-14-2021 8:02:29 AM"),
						Modified = DateTime.Parse("5-16-2021 10:21:53 AM"),
						CreatedBy = "Amparo Halvorson",
						ModifiedBy = "Morton Cummerata",
						Reason = "Perennial allergic rhinitis with seasonal variation",
						PatientId = 27,
						ProviderId = 27
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-16-2019 9:07:01 AM"),
						Created = DateTime.Parse("3-11-2020 1:18:26 PM"),
						Modified = DateTime.Parse("5-28-2020 11:25:36 AM"),
						CreatedBy = "Summer Medhurst",
						ModifiedBy = "Nathaniel Bernier",
						Reason = "Seizure disorder",
						PatientId = 28,
						ProviderId = 28
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-13-2020 5:54:39 PM"),
						Created = DateTime.Parse("4-17-2020 3:31:52 PM"),
						Modified = DateTime.Parse("6-30-2020 11:44:07 AM"),
						CreatedBy = "Ervin Douglas",
						ModifiedBy = "Lindsey Olson",
						Reason = "Small cell carcinoma of lung (disorder)",
						PatientId = 29,
						ProviderId = 29
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-8-2019 4:09:17 PM"),
						Created = DateTime.Parse("8-13-2019 5:18:23 PM"),
						Modified = DateTime.Parse("11-13-2019 1:34:40 PM"),
						CreatedBy = "Sonya Davis",
						ModifiedBy = "Mose O'Conner",
						Reason = "Chronic congestive heart failure (disorder)",
						PatientId = 30,
						ProviderId = 30
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-23-2020 9:02:05 AM"),
						Created = DateTime.Parse("7-29-2020 11:16:11 AM"),
						Modified = DateTime.Parse("9-23-2020 8:42:56 AM"),
						CreatedBy = "Essie Morar",
						ModifiedBy = "Kandace Mann",
						Reason = "Fracture of ankle",
						PatientId = 31,
						ProviderId = 31
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-11-2020 11:16:56 AM"),
						Created = DateTime.Parse("11-18-2020 2:49:34 PM"),
						Modified = DateTime.Parse("3-8-2021 2:14:37 PM"),
						CreatedBy = "Marylouise Windler",
						ModifiedBy = "Quinton Hammes",
						Reason = "Drug overdose",
						PatientId = 32,
						ProviderId = 32
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-22-2019 9:23:15 AM"),
						Created = DateTime.Parse("3-12-2020 2:21:22 PM"),
						Modified = DateTime.Parse("4-17-2020 4:54:04 PM"),
						CreatedBy = "Warner Glover",
						ModifiedBy = "India Flatley",
						Reason = "Second degree burn",
						PatientId = 33,
						ProviderId = 33
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-31-2020 4:00:55 PM"),
						Created = DateTime.Parse("6-10-2020 9:24:01 AM"),
						Modified = DateTime.Parse("8-3-2020 9:02:18 AM"),
						CreatedBy = "Jenniffer Emmerich",
						ModifiedBy = "Andreas McClure",
						Reason = "Fracture of ankle",
						PatientId = 34,
						ProviderId = 34
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-3-2019 4:10:49 PM"),
						Created = DateTime.Parse("5-9-2019 3:49:31 PM"),
						Modified = DateTime.Parse("8-25-2019 4:48:55 PM"),
						CreatedBy = "Tennie Kling",
						ModifiedBy = "Walton Prohaska",
						Reason = "Non-small cell lung cancer (disorder)",
						PatientId = 35,
						ProviderId = 35
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-27-2019 3:49:31 PM"),
						Created = DateTime.Parse("11-1-2019 3:11:23 PM"),
						Modified = DateTime.Parse("2-16-2020 11:34:13 AM"),
						CreatedBy = "Tod Quigley",
						ModifiedBy = "Honey Roberts",
						Reason = "Chronic obstructive bronchitis (disorder)",
						PatientId = 36,
						ProviderId = 36
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-30-2020 9:58:54 AM"),
						Created = DateTime.Parse("6-8-2020 11:14:17 AM"),
						Modified = DateTime.Parse("7-24-2020 1:59:46 PM"),
						CreatedBy = "Ervin Fadel",
						ModifiedBy = "Nevada Waelchi",
						Reason = "Fracture of clavicle",
						PatientId = 37,
						ProviderId = 37
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-1-2020 10:59:48 AM"),
						Created = DateTime.Parse("1-20-2021 9:58:54 AM"),
						Modified = DateTime.Parse("5-17-2021 3:49:31 PM"),
						CreatedBy = "Jose Jast",
						ModifiedBy = "Jules Cole",
						Reason = "Primary fibromyalgia syndrome",
						PatientId = 38,
						ProviderId = 38
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-16-2019 1:27:18 PM"),
						Created = DateTime.Parse("10-28-2019 2:15:24 PM"),
						Modified = DateTime.Parse("12-30-2019 10:12:45 AM"),
						CreatedBy = "Brain Auer",
						ModifiedBy = "Janise Senger",
						Reason = "First degree burn",
						PatientId = 39,
						ProviderId = 39
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("4-15-2020 10:32:33 AM"),
						Created = DateTime.Parse("6-28-2020 2:48:15 PM"),
						Modified = DateTime.Parse("9-30-2020 9:50:41 AM"),
						CreatedBy = "Harriet DuBuque",
						ModifiedBy = "Susanne Turcotte",
						Reason = "Neuropathy due to type 2 diabetes mellitus (disorder)",
						PatientId = 40,
						ProviderId = 40
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-6-2019 8:17:31 AM"),
						Created = DateTime.Parse("12-10-2019 2:05:10 PM"),
						Modified = DateTime.Parse("4-7-2020 4:48:55 PM"),
						CreatedBy = "Joni Schuppe",
						ModifiedBy = "Mara?a Eugenia Ybarra",
						Reason = "Posttraumatic stress disorder",
						PatientId = 41,
						ProviderId = 41
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-26-2019 9:37:39 AM"),
						Created = DateTime.Parse("9-13-2019 10:08:51 AM"),
						Modified = DateTime.Parse("12-30-2019 5:31:19 PM"),
						CreatedBy = "Royal Schuppe",
						ModifiedBy = "Francisca Wilderman",
						Reason = "Pulmonary emphysema (disorder)",
						PatientId = 42,
						ProviderId = 42
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-12-2019 4:38:53 PM"),
						Created = DateTime.Parse("5-25-2019 11:14:17 AM"),
						Modified = DateTime.Parse("8-9-2019 3:21:28 PM"),
						CreatedBy = "Maryland Yundt",
						ModifiedBy = "Matilde Adams",
						Reason = "Familial Alzheimer's disease of early onset (disorder)",
						PatientId = 43,
						ProviderId = 43
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-13-2019 5:27:01 PM"),
						Created = DateTime.Parse("10-24-2019 5:21:00 PM"),
						Modified = DateTime.Parse("12-28-2019 5:17:32 PM"),
						CreatedBy = "Pauline Hudson",
						ModifiedBy = "Jan Daugherty",
						Reason = "Pneumonia",
						PatientId = 44,
						ProviderId = 44
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-9-2019 3:05:08 PM"),
						Created = DateTime.Parse("12-14-2019 5:04:36 PM"),
						Modified = DateTime.Parse("3-17-2020 5:04:36 PM"),
						CreatedBy = "Stanton Miller",
						ModifiedBy = "Miquel Auer",
						Reason = "Familial Alzheimer's disease of early onset (disorder)",
						PatientId = 45,
						ProviderId = 45
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-18-2019 11:45:10 AM"),
						Created = DateTime.Parse("6-16-2019 2:49:34 PM"),
						Modified = DateTime.Parse("10-13-2019 1:18:26 PM"),
						CreatedBy = "Marco Veum",
						ModifiedBy = "Lydia Morissette",
						Reason = "Injury of medial collateral ligament of knee",
						PatientId = 46,
						ProviderId = 46
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-29-2020 10:43:01 AM"),
						Created = DateTime.Parse("9-2-2020 4:09:17 PM"),
						Modified = DateTime.Parse("11-15-2020 10:29:01 AM"),
						CreatedBy = "Darrick Torp",
						ModifiedBy = "Aracely Halvorson",
						Reason = "Secondary malignant neoplasm of colon",
						PatientId = 47,
						ProviderId = 47
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-2-2019 5:31:19 PM"),
						Created = DateTime.Parse("1-14-2020 2:04:50 PM"),
						Modified = DateTime.Parse("4-17-2020 8:17:50 AM"),
						CreatedBy = "John Bradtke",
						ModifiedBy = "Audry Murray",
						Reason = "Primary malignant neoplasm of colon",
						PatientId = 48,
						ProviderId = 48
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-18-2019 4:02:58 PM"),
						Created = DateTime.Parse("8-9-2019 9:06:04 AM"),
						Modified = DateTime.Parse("10-20-2019 4:15:47 PM"),
						CreatedBy = "Jule Tremblay",
						ModifiedBy = "Jacquie Wuckert",
						Reason = "Chronic intractable migraine without aura",
						PatientId = 49,
						ProviderId = 49
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-29-2019 9:50:41 AM"),
						Created = DateTime.Parse("12-1-2019 10:48:34 AM"),
						Modified = DateTime.Parse("2-16-2020 5:51:13 PM"),
						CreatedBy = "Piedad Zemlak",
						ModifiedBy = "Amanda Hahn",
						Reason = "Posttraumatic stress disorder",
						PatientId = 50,
						ProviderId = 50
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-13-2019 8:19:31 AM"),
						Created = DateTime.Parse("7-1-2019 10:05:27 AM"),
						Modified = DateTime.Parse("10-19-2019 2:58:15 PM"),
						CreatedBy = "Ramon Smith",
						ModifiedBy = "Josiah Bernier",
						Reason = "Malignant neoplasm of breast (disorder)",
						PatientId = 51,
						ProviderId = 51
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-21-2020 3:52:27 PM"),
						Created = DateTime.Parse("7-23-2020 3:52:27 PM"),
						Modified = DateTime.Parse("10-21-2020 4:06:50 PM"),
						CreatedBy = "Malcom Conroy",
						ModifiedBy = "Li Labadie",
						Reason = "Pyelonephritis",
						PatientId = 52,
						ProviderId = 52
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-3-2020 4:00:54 PM"),
						Created = DateTime.Parse("1-1-2021 9:02:05 AM"),
						Modified = DateTime.Parse("2-24-2021 11:19:40 AM"),
						CreatedBy = "Emory Lemke",
						ModifiedBy = "Micheal Mitchell",
						Reason = "Fetus with unknown complication",
						PatientId = 53,
						ProviderId = 53
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-21-2020 9:46:42 AM"),
						Created = DateTime.Parse("11-6-2020 1:47:38 PM"),
						Modified = DateTime.Parse("2-14-2021 10:08:51 AM"),
						CreatedBy = "Barbara Mota",
						ModifiedBy = "Clorinda Strosin",
						Reason = "Fetus with chromosomal abnormality",
						PatientId = 54,
						ProviderId = 54
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-17-2020 10:43:01 AM"),
						Created = DateTime.Parse("3-18-2020 4:44:21 PM"),
						Modified = DateTime.Parse("4-29-2020 9:23:15 AM"),
						CreatedBy = "Carlita Cremin",
						ModifiedBy = "Forest Gerlach",
						Reason = "Fracture of forearm",
						PatientId = 55,
						ProviderId = 55
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-31-2020 1:59:46 PM"),
						Created = DateTime.Parse("3-11-2021 10:03:20 AM"),
						Modified = DateTime.Parse("6-20-2021 5:40:05 PM"),
						CreatedBy = "Deedra Lemke",
						ModifiedBy = "Stanford Terry",
						Reason = "First degree burn",
						PatientId = 56,
						ProviderId = 56
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-24-2019 9:09:20 AM"),
						Created = DateTime.Parse("7-27-2019 4:12:32 PM"),
						Modified = DateTime.Parse("9-27-2019 5:31:54 PM"),
						CreatedBy = "Fernando Villanueva",
						ModifiedBy = "Rosette Doyle",
						Reason = "Primary malignant neoplasm of colon",
						PatientId = 57,
						ProviderId = 57
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-22-2019 8:02:29 AM"),
						Created = DateTime.Parse("6-18-2019 9:07:01 AM"),
						Modified = DateTime.Parse("10-11-2019 1:34:40 PM"),
						CreatedBy = "Tim Medhurst",
						ModifiedBy = "Theo Erdman",
						Reason = "Neoplasm of prostate",
						PatientId = 58,
						ProviderId = 58
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("3-16-2019 3:36:32 PM"),
						Created = DateTime.Parse("5-14-2019 2:05:58 PM"),
						Modified = DateTime.Parse("7-15-2019 8:02:41 AM"),
						CreatedBy = "Gaston Nader",
						ModifiedBy = "Rickey Kiehn",
						Reason = "Chronic congestive heart failure (disorder)",
						PatientId = 59,
						ProviderId = 59
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-19-2020 11:10:11 AM"),
						Created = DateTime.Parse("2-2-2021 10:34:08 AM"),
						Modified = DateTime.Parse("5-11-2021 3:09:07 PM"),
						CreatedBy = "Beatriz Ortega",
						ModifiedBy = "Zonia Cormier",
						Reason = "Bleeding from anus",
						PatientId = 60,
						ProviderId = 60
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-9-2019 5:31:54 PM"),
						Created = DateTime.Parse("12-10-2019 8:49:12 AM"),
						Modified = DateTime.Parse("1-10-2020 8:49:12 AM"),
						CreatedBy = "Cammy Wolff",
						ModifiedBy = "Alton Schmitt",
						Reason = "Posttraumatic stress disorder",
						PatientId = 61,
						ProviderId = 61
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-12-2019 10:34:08 AM"),
						Created = DateTime.Parse("10-20-2019 9:09:20 AM"),
						Modified = DateTime.Parse("1-3-2020 10:21:19 AM"),
						CreatedBy = "Herna?n Esquibel",
						ModifiedBy = "Bethany Zulauf",
						Reason = "Localized  primary osteoarthritis of the hand",
						PatientId = 62,
						ProviderId = 62
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("7-20-2020 8:49:12 AM"),
						Created = DateTime.Parse("9-27-2020 11:57:18 AM"),
						Modified = DateTime.Parse("12-21-2020 10:07:00 AM"),
						CreatedBy = "Irving Jaskolski",
						ModifiedBy = "Lashawna O'Conner",
						Reason = "Primary fibromyalgia syndrome",
						PatientId = 63,
						ProviderId = 63
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-16-2019 2:21:22 PM"),
						Created = DateTime.Parse("2-23-2020 11:16:11 AM"),
						Modified = DateTime.Parse("5-6-2020 2:05:10 PM"),
						CreatedBy = "Anjanette Mertz",
						ModifiedBy = "Drema Bogisich",
						Reason = "Malignant neoplasm of breast (disorder)",
						PatientId = 64,
						ProviderId = 64
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("2-18-2020 3:27:55 PM"),
						Created = DateTime.Parse("6-2-2020 9:24:08 AM"),
						Modified = DateTime.Parse("8-25-2020 1:57:51 PM"),
						CreatedBy = "Jorge Riojas",
						ModifiedBy = "Jerrell Gusikowski",
						Reason = "Childhood asthma",
						PatientId = 65,
						ProviderId = 65
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-6-2020 1:22:40 PM"),
						Created = DateTime.Parse("2-1-2021 1:21:18 PM"),
						Modified = DateTime.Parse("5-5-2021 5:20:12 PM"),
						CreatedBy = "Margarette Nikolaus",
						ModifiedBy = "Traci Jones",
						Reason = "Posttraumatic stress disorder",
						PatientId = 66,
						ProviderId = 66
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-5-2020 3:06:00 PM"),
						Created = DateTime.Parse("7-2-2020 4:17:08 PM"),
						Modified = DateTime.Parse("10-13-2020 9:49:01 AM"),
						CreatedBy = "Loria Thompson",
						ModifiedBy = "Marita Fahey",
						Reason = "Localized  primary osteoarthritis of the hand",
						PatientId = 67,
						ProviderId = 67
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-9-2019 9:57:27 AM"),
						Created = DateTime.Parse("9-27-2019 3:57:27 PM"),
						Modified = DateTime.Parse("11-1-2019 11:00:26 AM"),
						CreatedBy = "Fernande Toy",
						ModifiedBy = "Linwood Kub",
						Reason = "Osteoarthritis of hip",
						PatientId = 68,
						ProviderId = 68
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-29-2019 5:27:16 PM"),
						Created = DateTime.Parse("9-1-2019 2:58:15 PM"),
						Modified = DateTime.Parse("11-22-2019 2:12:19 PM"),
						CreatedBy = "Bella Mann",
						ModifiedBy = "Abdul O'Connell",
						Reason = "Polyp of colon",
						PatientId = 69,
						ProviderId = 69
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("4-30-2019 9:06:04 AM"),
						Created = DateTime.Parse("7-26-2019 9:16:35 AM"),
						Modified = DateTime.Parse("8-25-2019 9:06:04 AM"),
						CreatedBy = "Xavier Weissnat",
						ModifiedBy = "Magali Lubowitz",
						Reason = "Malignant neoplasm of breast (disorder)",
						PatientId = 70,
						ProviderId = 70
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-12-2020 10:38:15 AM"),
						Created = DateTime.Parse("2-7-2021 4:00:00 PM"),
						Modified = DateTime.Parse("5-11-2021 3:31:52 PM"),
						CreatedBy = "Pearl Daniel",
						ModifiedBy = "Federico Maendez",
						Reason = "Tubal pregnancy",
						PatientId = 71,
						ProviderId = 71
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("4-5-2020 2:22:27 PM"),
						Created = DateTime.Parse("7-15-2020 11:14:17 AM"),
						Modified = DateTime.Parse("10-14-2020 10:59:48 AM"),
						CreatedBy = "Armando Heathcote",
						ModifiedBy = "Julio Heller",
						Reason = "Malignant neoplasm of breast (disorder)",
						PatientId = 72,
						ProviderId = 72
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-27-2020 1:59:46 PM"),
						Created = DateTime.Parse("9-10-2020 9:56:49 AM"),
						Modified = DateTime.Parse("12-14-2020 3:36:32 PM"),
						CreatedBy = "Ressie Schamberger",
						ModifiedBy = "Terrence Schmeler",
						Reason = "Polyp of colon",
						PatientId = 73,
						ProviderId = 73
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-28-2019 5:52:42 PM"),
						Created = DateTime.Parse("1-23-2020 2:29:08 PM"),
						Modified = DateTime.Parse("3-30-2020 8:13:22 AM"),
						CreatedBy = "Jaimie Barton",
						ModifiedBy = "Melani Bode",
						Reason = "Seasonal allergic rhinitis",
						PatientId = 74,
						ProviderId = 74
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("4-25-2020 5:18:23 PM"),
						Created = DateTime.Parse("8-18-2020 4:02:58 PM"),
						Modified = DateTime.Parse("9-17-2020 10:09:46 AM"),
						CreatedBy = "Jeri Shields",
						ModifiedBy = "Terese Reynolds",
						Reason = "Non-small cell carcinoma of lung  TNM stage 1 (disorder)",
						PatientId = 75,
						ProviderId = 75
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-8-2020 2:21:22 PM"),
						Created = DateTime.Parse("8-27-2020 10:48:34 AM"),
						Modified = DateTime.Parse("12-11-2020 8:13:22 AM"),
						CreatedBy = "Octavio Aparicio",
						ModifiedBy = "Gaylord Anderson",
						Reason = "Laparoscopic Removal of Gall Bladder",
						PatientId = 76,
						ProviderId = 76
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("1-9-2019 11:45:10 AM"),
						Created = DateTime.Parse("3-21-2019 1:47:38 PM"),
						Modified = DateTime.Parse("5-28-2019 1:22:40 PM"),
						CreatedBy = "Steve Roob",
						ModifiedBy = "Rocky Orn",
						Reason = "Gout",
						PatientId = 77,
						ProviderId = 77
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("5-9-2020 1:15:29 PM"),
						Created = DateTime.Parse("9-4-2020 9:58:54 AM"),
						Modified = DateTime.Parse("11-21-2020 9:04:24 AM"),
						CreatedBy = "Natalia Melaendez",
						ModifiedBy = "Fausto Cummings",
						Reason = "Neoplasm of prostate",
						PatientId = 78,
						ProviderId = 78
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-25-2020 8:17:43 AM"),
						Created = DateTime.Parse("12-2-2020 4:09:17 PM"),
						Modified = DateTime.Parse("3-10-2021 11:50:45 AM"),
						CreatedBy = "Suzanna Jacobs",
						ModifiedBy = "Lynn Thiel",
						Reason = "Alzheimer's disease (disorder)",
						PatientId = 79,
						ProviderId = 79
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-5-2020 1:22:40 PM"),
						Created = DateTime.Parse("9-24-2020 3:58:31 PM"),
						Modified = DateTime.Parse("1-17-2021 11:19:40 AM"),
						CreatedBy = "Houston Bailey",
						ModifiedBy = "Rene Hayes",
						Reason = "Overlapping malignant neoplasm of colon",
						PatientId = 80,
						ProviderId = 80
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-12-2020 1:27:18 PM"),
						Created = DateTime.Parse("2-5-2021 10:43:00 AM"),
						Modified = DateTime.Parse("5-2-2021 11:45:10 AM"),
						CreatedBy = "Charolette Schaden",
						ModifiedBy = "Karly Gaylord",
						Reason = "Fetus with chromosomal abnormality",
						PatientId = 81,
						ProviderId = 81
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-11-2019 11:50:45 AM"),
						Created = DateTime.Parse("1-5-2020 3:51:08 PM"),
						Modified = DateTime.Parse("4-11-2020 9:46:42 AM"),
						CreatedBy = "Suellen Von",
						ModifiedBy = "Beatriz Ortega",
						Reason = "Chronic congestive heart failure (disorder)",
						PatientId = 82,
						ProviderId = 82
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("11-1-2020 8:59:04 AM"),
						Created = DateTime.Parse("1-30-2021 10:08:51 AM"),
						Modified = DateTime.Parse("4-19-2021 5:14:24 PM"),
						CreatedBy = "Rafael Wunsch",
						ModifiedBy = "Kati Kessler",
						Reason = "Neuropathy due to type 2 diabetes mellitus (disorder)",
						PatientId = 83,
						ProviderId = 83
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-14-2020 2:33:49 PM"),
						Created = DateTime.Parse("11-15-2020 9:25:36 AM"),
						Modified = DateTime.Parse("3-13-2021 9:38:12 AM"),
						CreatedBy = "Manuela Anguiano",
						ModifiedBy = "Era Reichert",
						Reason = "Acute bronchitis (disorder)",
						PatientId = 84,
						ProviderId = 84
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-28-2019 5:48:11 PM"),
						Created = DateTime.Parse("12-12-2019 5:56:13 PM"),
						Modified = DateTime.Parse("2-17-2020 2:52:22 PM"),
						CreatedBy = "Rory McLaughlin",
						ModifiedBy = "Salina Kozey",
						Reason = "Primary small cell malignant neoplasm of lung  TNM stage 1 (disorder)",
						PatientId = 85,
						ProviderId = 85
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-6-2019 3:13:30 PM"),
						Created = DateTime.Parse("11-15-2019 1:27:18 PM"),
						Modified = DateTime.Parse("3-3-2020 9:45:55 AM"),
						CreatedBy = "Leonardo Hills",
						ModifiedBy = "Malcolm Bradtke",
						Reason = "Second degree burn",
						PatientId = 86,
						ProviderId = 86
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-2-2020 8:59:04 AM"),
						Created = DateTime.Parse("12-3-2020 10:38:15 AM"),
						Modified = DateTime.Parse("1-22-2021 11:15:51 AM"),
						CreatedBy = "Jolyn Bechtelar",
						ModifiedBy = "Carroll Beer",
						Reason = "Pyelonephritis",
						PatientId = 87,
						ProviderId = 87
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-5-2019 8:17:31 AM"),
						Created = DateTime.Parse("12-8-2019 5:27:01 PM"),
						Modified = DateTime.Parse("2-22-2020 3:11:23 PM"),
						CreatedBy = "Ryan Heller",
						ModifiedBy = "Christin Rice",
						Reason = "Malignant neoplasm of breast (disorder)",
						PatientId = 88,
						ProviderId = 88
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-6-2019 4:54:04 PM"),
						Created = DateTime.Parse("9-5-2019 8:49:37 AM"),
						Modified = DateTime.Parse("12-11-2019 9:55:04 AM"),
						CreatedBy = "Ivana Berge",
						ModifiedBy = "Julio Powlowski",
						Reason = "Fetus with chromosomal abnormality",
						PatientId = 89,
						ProviderId = 89
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-16-2019 3:06:00 PM"),
						Created = DateTime.Parse("4-1-2020 3:51:08 PM"),
						Modified = DateTime.Parse("5-14-2020 9:46:42 AM"),
						CreatedBy = "Rocky Ferry",
						ModifiedBy = "Will Murphy",
						Reason = "Chronic congestive heart failure (disorder)",
						PatientId = 90,
						ProviderId = 90
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-2-2019 5:27:16 PM"),
						Created = DateTime.Parse("11-28-2019 11:29:54 AM"),
						Modified = DateTime.Parse("1-15-2020 1:16:09 PM"),
						CreatedBy = "Teresita Hickle",
						ModifiedBy = "Laila Lemke",
						Reason = "Rheumatoid arthritis",
						PatientId = 91,
						ProviderId = 91
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("4-11-2019 9:45:55 AM"),
						Created = DateTime.Parse("6-2-2019 5:21:00 PM"),
						Modified = DateTime.Parse("8-28-2019 11:30:45 AM"),
						CreatedBy = "Sherley Upton",
						ModifiedBy = "Dudley Lueilwitz",
						Reason = "Hyperlipidemia",
						PatientId = 92,
						ProviderId = 92
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-20-2020 10:09:46 AM"),
						Created = DateTime.Parse("11-26-2020 8:02:29 AM"),
						Modified = DateTime.Parse("1-21-2021 5:48:11 PM"),
						CreatedBy = "Warner Glover",
						ModifiedBy = "Octavio Aparicio",
						Reason = "Posttraumatic stress disorder",
						PatientId = 93,
						ProviderId = 93
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("8-8-2019 10:59:48 AM"),
						Created = DateTime.Parse("10-10-2019 11:30:45 AM"),
						Modified = DateTime.Parse("11-28-2019 4:10:49 PM"),
						CreatedBy = "Jannet West",
						ModifiedBy = "Awilda Balistreri",
						Reason = "Bleeding from anus",
						PatientId = 94,
						ProviderId = 94
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("6-21-2020 1:27:18 PM"),
						Created = DateTime.Parse("9-21-2020 3:10:01 PM"),
						Modified = DateTime.Parse("12-18-2020 2:20:23 PM"),
						CreatedBy = "Michale Gibson",
						ModifiedBy = "Humberto Mitchell",
						Reason = "Normal pregnancy",
						PatientId = 95,
						ProviderId = 95
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("10-13-2020 2:04:50 PM"),
						Created = DateTime.Parse("11-13-2020 4:26:59 PM"),
						Modified = DateTime.Parse("2-21-2021 9:09:20 AM"),
						CreatedBy = "Odell Lubowitz",
						ModifiedBy = "Alfredo Hickle",
						Reason = "Childhood asthma",
						PatientId = 96,
						ProviderId = 96
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("1-12-2019 1:15:29 PM"),
						Created = DateTime.Parse("3-20-2019 4:28:17 PM"),
						Modified = DateTime.Parse("7-18-2019 5:03:23 PM"),
						CreatedBy = "Mayte Va?zquez",
						ModifiedBy = "Alease Dare",
						Reason = "Primary fibromyalgia syndrome",
						PatientId = 97,
						ProviderId = 97
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-12-2019 3:58:31 PM"),
						Created = DateTime.Parse("1-9-2020 3:27:55 PM"),
						Modified = DateTime.Parse("2-28-2020 9:16:35 AM"),
						CreatedBy = "Lashanda Kuhic",
						ModifiedBy = "Kerry Miller",
						Reason = "Seasonal allergic rhinitis",
						PatientId = 98,
						ProviderId = 98
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("9-20-2019 9:56:49 AM"),
						Created = DateTime.Parse("11-21-2019 9:00:32 AM"),
						Modified = DateTime.Parse("1-19-2020 3:00:13 PM"),
						CreatedBy = "Rachal Ruecker",
						ModifiedBy = "Greg Kshlerin",
						Reason = "Injury of tendon of the rotator cuff of shoulder",
						PatientId = 99,
						ProviderId = 99
					},
				new Appointment
					{
						AppointmentDate = DateTime.Parse("12-17-2019 4:17:09 PM"),
						Created = DateTime.Parse("2-11-2020 11:38:50 AM"),
						Modified = DateTime.Parse("3-16-2020 9:45:01 AM"),
						CreatedBy = "Yoshiko Casper",
						ModifiedBy = "Mara?a Luisa Canta?",
						Reason = "Suspected lung cancer (situation)",
						PatientId = 100,
						ProviderId = 100
					}

				};
			appointments.ForEach(a => context.Appoinments.AddOrUpdate(a));
			context.SaveChanges();

			if (context.Vitals.Any())
				{
				return;
				}

			var vitals = new List<Vital>
				{
								new Vital
					{
						VitalDate = DateTime.Parse("9-27-2019"),
						Weight = "79.5 kg",
						Height = "177.2 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "117 / 78 mm[Hg]",
						Pulse = "92",
						Created = DateTime.Parse("9-27-2019"),
						Modified = DateTime.Parse("9-27-2019"),
						CreatedBy = "Hue McKenzie",
						ModifiedBy = "Hue McKenzie",
						PatientId = 1
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-23-2019"),
						Weight = "84.6 kg",
						Height = "177.2 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "120 / 74 mm[Hg]",
						Pulse = "96",
						Created = DateTime.Parse("6-23-2019"),
						Modified = DateTime.Parse("6-23-2019"),
						CreatedBy = "Almeda Larkin",
						ModifiedBy = "Almeda Larkin",
						PatientId = 2
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-10-2020"),
						Weight = "88.7 kg",
						Height = "177.2 cm",
						Temperature = "38.1 Cel",
						BloodPressure = "116 / 80 mm[Hg]",
						Pulse = "88",
						Created = DateTime.Parse("8-10-2020"),
						Modified = DateTime.Parse("8-10-2020"),
						CreatedBy = "Elias Mueller",
						ModifiedBy = "Elias Mueller",
						PatientId = 3
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-16-2020"),
						Weight = "70.5 kg",
						Height = "158.2 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "119 / 76 mm[Hg]",
						Pulse = "78",
						Created = DateTime.Parse("2-16-2020"),
						Modified = DateTime.Parse("2-16-2020"),
						CreatedBy = "Tanja Koepp",
						ModifiedBy = "Tanja Koepp",
						PatientId = 4
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-17-2019"),
						Weight = "80.9 kg",
						Height = "170.5 cm",
						Temperature = "38.2 Cel",
						BloodPressure = "131 / 82 mm[Hg]",
						Pulse = "92",
						Created = DateTime.Parse("4-17-2019"),
						Modified = DateTime.Parse("4-17-2019"),
						CreatedBy = "Mateo Carrasco",
						ModifiedBy = "Mateo Carrasco",
						PatientId = 5
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-26-2019"),
						Weight = "12.7 kg",
						Height = "92.1 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "116 / 74 mm[Hg]",
						Pulse = "70",
						Created = DateTime.Parse("8-26-2019"),
						Modified = DateTime.Parse("8-26-2019"),
						CreatedBy = "Antonia Leuschke",
						ModifiedBy = "Antonia Leuschke",
						PatientId = 6
					},
				new Vital
					{
						VitalDate = DateTime.Parse("1-11-2020"),
						Weight = "13.5 kg",
						Height = "95.7 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "124 / 82 mm[Hg]",
						Pulse = "94",
						Created = DateTime.Parse("1-11-2020"),
						Modified = DateTime.Parse("1-11-2020"),
						CreatedBy = "Renata Purdy",
						ModifiedBy = "Renata Purdy",
						PatientId = 7
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-13-2020"),
						Weight = "72.9 kg",
						Height = "158.8 cm",
						Temperature = "37 Cel",
						BloodPressure = "118 / 81 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("9-13-2020"),
						Modified = DateTime.Parse("9-13-2020"),
						CreatedBy = "Juan Da?az",
						ModifiedBy = "Juan Da?az",
						PatientId = 8
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-2-2019"),
						Weight = "14.4 kg",
						Height = "99.1 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "128 / 69 mm[Hg]",
						Pulse = "77",
						Created = DateTime.Parse("4-2-2019"),
						Modified = DateTime.Parse("4-2-2019"),
						CreatedBy = "Eleanora Swift",
						ModifiedBy = "Eleanora Swift",
						PatientId = 9
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-7-2020"),
						Weight = "80.9 kg",
						Height = "170.5 cm",
						Temperature = "37 Cel",
						BloodPressure = "123 / 74 mm[Hg]",
						Pulse = "89",
						Created = DateTime.Parse("8-7-2020"),
						Modified = DateTime.Parse("8-7-2020"),
						CreatedBy = "Dick White",
						ModifiedBy = "Dick White",
						PatientId = 10
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-28-2019"),
						Weight = "74.9 kg",
						Height = "159 cm",
						Temperature = "39 Cel",
						BloodPressure = "113 / 80 mm[Hg]",
						Pulse = "67",
						Created = DateTime.Parse("10-28-2019"),
						Modified = DateTime.Parse("10-28-2019"),
						CreatedBy = "Odis Daugherty",
						ModifiedBy = "Odis Daugherty",
						PatientId = 11
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-24-2019"),
						Weight = "16.1 kg",
						Height = "105.5 cm",
						Temperature = "38 Cel",
						BloodPressure = "126 / 84 mm[Hg]",
						Pulse = "79",
						Created = DateTime.Parse("6-24-2019"),
						Modified = DateTime.Parse("6-24-2019"),
						CreatedBy = "Xavier Weissnat",
						ModifiedBy = "Xavier Weissnat",
						PatientId = 12
					},
				new Vital
					{
						VitalDate = DateTime.Parse("1-31-2019"),
						Weight = "18 kg",
						Height = "111.7 cm",
						Temperature = "39.1 Cel",
						BloodPressure = "117 / 78 mm[Hg]",
						Pulse = "78",
						Created = DateTime.Parse("1-31-2019"),
						Modified = DateTime.Parse("1-31-2019"),
						CreatedBy = "Tobias Cremin",
						ModifiedBy = "Tobias Cremin",
						PatientId = 13
					},
				new Vital
					{
						VitalDate = DateTime.Parse("1-10-2020"),
						Weight = "80.9 kg",
						Height = "170.5 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "101 / 77 mm[Hg]",
						Pulse = "93",
						Created = DateTime.Parse("1-10-2020"),
						Modified = DateTime.Parse("1-10-2020"),
						CreatedBy = "Mayra Brakus",
						ModifiedBy = "Mayra Brakus",
						PatientId = 14
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-18-2019"),
						Weight = "74.9 kg",
						Height = "159 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "128 / 78 mm[Hg]",
						Pulse = "59",
						Created = DateTime.Parse("8-18-2019"),
						Modified = DateTime.Parse("8-18-2019"),
						CreatedBy = "Jamar Wisozk",
						ModifiedBy = "Jamar Wisozk",
						PatientId = 15
					},
				new Vital
					{
						VitalDate = DateTime.Parse("3-3-2019"),
						Weight = "80.9 kg",
						Height = "170.5 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "103 / 82 mm[Hg]",
						Pulse = "92",
						Created = DateTime.Parse("3-3-2019"),
						Modified = DateTime.Parse("3-3-2019"),
						CreatedBy = "Susana Lockman",
						ModifiedBy = "Susana Lockman",
						PatientId = 16
					},
				new Vital
					{
						VitalDate = DateTime.Parse("3-28-2019"),
						Weight = "20 kg",
						Height = "117.8 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "113 / 70 mm[Hg]",
						Pulse = "66",
						Created = DateTime.Parse("3-28-2019"),
						Modified = DateTime.Parse("3-28-2019"),
						CreatedBy = "Harry Corwin",
						ModifiedBy = "Harry Corwin",
						PatientId = 17
					},
				new Vital
					{
						VitalDate = DateTime.Parse("7-26-2020"),
						Weight = "22.1 kg",
						Height = "123.7 cm",
						Temperature = "37 Cel",
						BloodPressure = "133 / 79 mm[Hg]",
						Pulse = "77",
						Created = DateTime.Parse("7-26-2020"),
						Modified = DateTime.Parse("7-26-2020"),
						CreatedBy = "Nathalie Gottlieb",
						ModifiedBy = "Nathalie Gottlieb",
						PatientId = 18
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-5-2020"),
						Weight = "24.6 kg",
						Height = "129.5 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "115 / 80 mm[Hg]",
						Pulse = "96",
						Created = DateTime.Parse("8-5-2020"),
						Modified = DateTime.Parse("8-5-2020"),
						CreatedBy = "Raelene Mills",
						ModifiedBy = "Raelene Mills",
						PatientId = 19
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-12-2019"),
						Weight = "27.1 kg",
						Height = "134.3 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "124 / 80 mm[Hg]",
						Pulse = "70",
						Created = DateTime.Parse("10-12-2019"),
						Modified = DateTime.Parse("10-12-2019"),
						CreatedBy = "Reanna Bernhard",
						ModifiedBy = "Reanna Bernhard",
						PatientId = 20
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-21-2019"),
						Weight = "30.1 kg",
						Height = "138.9 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "128 / 79 mm[Hg]",
						Pulse = "86",
						Created = DateTime.Parse("10-21-2019"),
						Modified = DateTime.Parse("10-21-2019"),
						CreatedBy = "Vanita Wyman",
						ModifiedBy = "Vanita Wyman",
						PatientId = 21
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-7-2020"),
						Weight = "81.6 kg",
						Height = "165.9 cm",
						Temperature = "39 Cel",
						BloodPressure = "125 / 81 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("9-7-2020"),
						Modified = DateTime.Parse("9-7-2020"),
						CreatedBy = "Carlota Corrales",
						ModifiedBy = "Carlota Corrales",
						PatientId = 22
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-16-2019"),
						Weight = "5.6 kg",
						Height = "60.2 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "107 / 80 mm[Hg]",
						Pulse = "61",
						Created = DateTime.Parse("2-16-2019"),
						Modified = DateTime.Parse("2-16-2019"),
						CreatedBy = "Laure Heathcote",
						ModifiedBy = "Laure Heathcote",
						PatientId = 23
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-11-2020"),
						Weight = "33.7 kg",
						Height = "144.2 cm",
						Temperature = "37.5 Cel",
						BloodPressure = "128 / 80 mm[Hg]",
						Pulse = "78",
						Created = DateTime.Parse("4-11-2020"),
						Modified = DateTime.Parse("4-11-2020"),
						CreatedBy = "Carey Considine",
						ModifiedBy = "Carey Considine",
						PatientId = 24
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-11-2019"),
						Weight = "6.6 kg",
						Height = "64.1 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "106 / 74 mm[Hg]",
						Pulse = "92",
						Created = DateTime.Parse("4-11-2019"),
						Modified = DateTime.Parse("4-11-2019"),
						CreatedBy = "Kenton Smith",
						ModifiedBy = "Kenton Smith",
						PatientId = 25
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-17-2020"),
						Weight = "33.7 kg",
						Height = "144.2 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "131 / 73 mm[Hg]",
						Pulse = "89",
						Created = DateTime.Parse("10-17-2020"),
						Modified = DateTime.Parse("10-17-2020"),
						CreatedBy = "Brooks Grant",
						ModifiedBy = "Brooks Grant",
						PatientId = 26
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-29-2020"),
						Weight = "7.9 kg",
						Height = "68.9 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "108 / 75 mm[Hg]",
						Pulse = "77",
						Created = DateTime.Parse("5-29-2020"),
						Modified = DateTime.Parse("5-29-2020"),
						CreatedBy = "Loyd McGlynn",
						ModifiedBy = "Loyd McGlynn",
						PatientId = 27
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-4-2019"),
						Weight = "77.3 kg",
						Height = "165.9 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "127 / 83 mm[Hg]",
						Pulse = "80",
						Created = DateTime.Parse("12-4-2019"),
						Modified = DateTime.Parse("12-4-2019"),
						CreatedBy = "Seth Trantow",
						ModifiedBy = "Seth Trantow",
						PatientId = 28
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-25-2019"),
						Weight = "8.9 kg",
						Height = "72.9 cm",
						Temperature = "38 Cel",
						BloodPressure = "122 / 80 mm[Hg]",
						Pulse = "71",
						Created = DateTime.Parse("4-25-2019"),
						Modified = DateTime.Parse("4-25-2019"),
						CreatedBy = "Shawn Luettgen",
						ModifiedBy = "Shawn Luettgen",
						PatientId = 29
					},
				new Vital
					{
						VitalDate = DateTime.Parse("7-9-2019"),
						Weight = "9.8 kg",
						Height = "76.4 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "121 / 78 mm[Hg]",
						Pulse = "91",
						Created = DateTime.Parse("7-9-2019"),
						Modified = DateTime.Parse("7-9-2019"),
						CreatedBy = "Erinn Nienow",
						ModifiedBy = "Erinn Nienow",
						PatientId = 30
					},
				new Vital
					{
						VitalDate = DateTime.Parse("7-28-2019"),
						Weight = "10.4 kg",
						Height = "79.5 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "113 / 76 mm[Hg]",
						Pulse = "83",
						Created = DateTime.Parse("7-28-2019"),
						Modified = DateTime.Parse("7-28-2019"),
						CreatedBy = "Ramiro Lakin",
						ModifiedBy = "Ramiro Lakin",
						PatientId = 31
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-10-2019"),
						Weight = "105.4 kg",
						Height = "85 cm",
						Temperature = "39 Cel",
						BloodPressure = "106 / 70 mm[Hg]",
						Pulse = "86",
						Created = DateTime.Parse("9-10-2019"),
						Modified = DateTime.Parse("9-10-2019"),
						CreatedBy = "Teresa Ortiz",
						ModifiedBy = "Teresa Ortiz",
						PatientId = 32
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-18-2020"),
						Weight = "105.4 kg",
						Height = "187.1 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "125 / 73 mm[Hg]",
						Pulse = "75",
						Created = DateTime.Parse("9-18-2020"),
						Modified = DateTime.Parse("9-18-2020"),
						CreatedBy = "Hisako Kuhlman",
						ModifiedBy = "Hisako Kuhlman",
						PatientId = 33
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-1-2020"),
						Weight = "11.4 kg",
						Height = "187.1 cm",
						Temperature = "37 Cel",
						BloodPressure = "132 / 76 mm[Hg]",
						Pulse = "66",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("12-1-2020"),
						CreatedBy = "Ralph Marks",
						ModifiedBy = "Ralph Marks",
						PatientId = 34
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-22-2019"),
						Weight = "12.3 kg",
						Height = "89.2 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "125 / 86 mm[Hg]",
						Pulse = "77",
						Created = DateTime.Parse("5-22-2019"),
						Modified = DateTime.Parse("5-22-2019"),
						CreatedBy = "Suzan Kuphal",
						ModifiedBy = "Suzan Kuphal",
						PatientId = 35
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-24-2020"),
						Weight = "105.4 kg",
						Height = "187.1 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "132 / 86 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("4-24-2020"),
						Modified = DateTime.Parse("4-24-2020"),
						CreatedBy = "Lashawna O'Conner",
						ModifiedBy = "Lashawna O'Conner",
						PatientId = 36
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-24-2019"),
						Weight = "13.1 kg",
						Height = "93.2 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "99. / 79 mm[Hg]",
						Pulse = "81",
						Created = DateTime.Parse("11-24-2019"),
						Modified = DateTime.Parse("11-24-2019"),
						CreatedBy = "Adena Wilkinson",
						ModifiedBy = "Adena Wilkinson",
						PatientId = 37
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-28-2020"),
						Weight = "14 kg",
						Height = "96.7 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "117 / 76 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("10-28-2020"),
						Modified = DateTime.Parse("10-28-2020"),
						CreatedBy = "Aundrea Kuphal",
						ModifiedBy = "Aundrea Kuphal",
						PatientId = 38
					},
				new Vital
					{
						VitalDate = DateTime.Parse("3-26-2019"),
						Weight = "14.6 kg",
						Height = "98.9 cm",
						Temperature = "39 Cel",
						BloodPressure = "110 / 78 mm[Hg]",
						Pulse = "71",
						Created = DateTime.Parse("3-26-2019"),
						Modified = DateTime.Parse("3-26-2019"),
						CreatedBy = "Tiana Hoeger",
						ModifiedBy = "Tiana Hoeger",
						PatientId = 39
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-19-2019"),
						Weight = "83 kg",
						Height = "165.9 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "119 / 77 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("4-19-2019"),
						Modified = DateTime.Parse("4-19-2019"),
						CreatedBy = "Grant Price",
						ModifiedBy = "Grant Price",
						PatientId = 40
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-16-2020"),
						Weight = "14.9 kg",
						Height = "100 cm",
						Temperature = "37.5 Cel",
						BloodPressure = "122 / 77 mm[Hg]",
						Pulse = "94",
						Created = DateTime.Parse("9-16-2020"),
						Modified = DateTime.Parse("9-16-2020"),
						CreatedBy = "Gaston Nader",
						ModifiedBy = "Gaston Nader",
						PatientId = 41
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-4-2019"),
						Weight = "105.4 kg",
						Height = "187.1 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "122 / 83 mm[Hg]",
						Pulse = "83",
						Created = DateTime.Parse("5-4-2019"),
						Modified = DateTime.Parse("5-4-2019"),
						CreatedBy = "Darnell Medhurst",
						ModifiedBy = "Darnell Medhurst",
						PatientId = 42
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-9-2019"),
						Weight = "16.8 kg",
						Height = "106.9 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "139 / 86 mm[Hg]",
						Pulse = "65",
						Created = DateTime.Parse("10-9-2019"),
						Modified = DateTime.Parse("10-9-2019"),
						CreatedBy = "Clarita Rice",
						ModifiedBy = "Clarita Rice",
						PatientId = 43
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-4-2020"),
						Weight = "23.5 kg",
						Height = "125.9 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "117 / 83 mm[Hg]",
						Pulse = "82",
						Created = DateTime.Parse("10-4-2020"),
						Modified = DateTime.Parse("10-4-2020"),
						CreatedBy = "Emogene Halvorson",
						ModifiedBy = "Emogene Halvorson",
						PatientId = 44
					},
				new Vital
					{
						VitalDate = DateTime.Parse("1-2-2020"),
						Weight = "105.4 kg",
						Height = "187.1 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "127 / 84 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("1-2-2020"),
						Modified = DateTime.Parse("1-2-2020"),
						CreatedBy = "Eugene Hudson",
						ModifiedBy = "Eugene Hudson",
						PatientId = 45
					},
				new Vital
					{
						VitalDate = DateTime.Parse("3-29-2019"),
						Weight = "18.9 kg",
						Height = "113.9 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "134 / 85 mm[Hg]",
						Pulse = "82",
						Created = DateTime.Parse("3-29-2019"),
						Modified = DateTime.Parse("3-29-2019"),
						CreatedBy = "Jorge Herna?ndez",
						ModifiedBy = "Jorge Herna?ndez",
						PatientId = 46
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-5-2020"),
						Weight = "26.5 kg",
						Height = "132.3 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "127 / 82 mm[Hg]",
						Pulse = "65",
						Created = DateTime.Parse("10-5-2020"),
						Modified = DateTime.Parse("10-5-2020"),
						CreatedBy = "Coleman Hagenes",
						ModifiedBy = "Coleman Hagenes",
						PatientId = 47
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-23-2019"),
						Weight = "30.4 kg",
						Height = "138.4 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "125 / 78 mm[Hg]",
						Pulse = "64",
						Created = DateTime.Parse("12-23-2019"),
						Modified = DateTime.Parse("12-23-2019"),
						CreatedBy = "Pat Nader",
						ModifiedBy = "Pat Nader",
						PatientId = 48
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-22-2019"),
						Weight = "95.2 kg",
						Height = "187.1 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "120 / 78 mm[Hg]",
						Pulse = "68",
						Created = DateTime.Parse("4-22-2019"),
						Modified = DateTime.Parse("4-22-2019"),
						CreatedBy = "Reggie Schmidt",
						ModifiedBy = "Reggie Schmidt",
						PatientId = 49
					},
				new Vital
					{
						VitalDate = DateTime.Parse("1-31-2019"),
						Weight = "34.6 kg",
						Height = "143.9 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "128 / 76 mm[Hg]",
						Pulse = "95",
						Created = DateTime.Parse("1-31-2019"),
						Modified = DateTime.Parse("1-31-2019"),
						CreatedBy = "Ginny Stamm",
						ModifiedBy = "Ginny Stamm",
						PatientId = 50
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-24-2020"),
						Weight = "39.2 kg",
						Height = "150.4 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "137 / 83 mm[Hg]",
						Pulse = "76",
						Created = DateTime.Parse("11-24-2020"),
						Modified = DateTime.Parse("11-24-2020"),
						CreatedBy = "Rick Boyer",
						ModifiedBy = "Rick Boyer",
						PatientId = 51
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-4-2019"),
						Weight = "97.6 kg",
						Height = "187.1 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "119 / 69 mm[Hg]",
						Pulse = "70",
						Created = DateTime.Parse("2-4-2019"),
						Modified = DateTime.Parse("2-4-2019"),
						CreatedBy = "Cara Ruecker",
						ModifiedBy = "Cara Ruecker",
						PatientId = 52
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-8-2019"),
						Weight = "21.2 kg",
						Height = "120.7 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "112 / 89 mm[Hg]",
						Pulse = "96",
						Created = DateTime.Parse("5-8-2019"),
						Modified = DateTime.Parse("5-8-2019"),
						CreatedBy = "Thaddeus Hegmann",
						ModifiedBy = "Thaddeus Hegmann",
						PatientId = 53
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-28-2019"),
						Weight = "43.8 kg",
						Height = "157.6 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "119 / 78 mm[Hg]",
						Pulse = "72",
						Created = DateTime.Parse("11-28-2019"),
						Modified = DateTime.Parse("11-28-2019"),
						CreatedBy = "Thaddeus Hegmann",
						ModifiedBy = "Thaddeus Hegmann",
						PatientId = 54
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-9-2019"),
						Weight = "23.8 kg",
						Height = "126.8 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "127 / 74 mm[Hg]",
						Pulse = "66",
						Created = DateTime.Parse("4-9-2019"),
						Modified = DateTime.Parse("4-9-2019"),
						CreatedBy = "Sharolyn Mayert",
						ModifiedBy = "Sharolyn Mayert",
						PatientId = 55
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-23-2019"),
						Weight = "100.2 kg",
						Height = "187.1 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "124 / 72 mm[Hg]",
						Pulse = "95",
						Created = DateTime.Parse("8-23-2019"),
						Modified = DateTime.Parse("8-23-2019"),
						CreatedBy = "Hollis Volkman",
						ModifiedBy = "Hollis Volkman",
						PatientId = 56
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-13-2020"),
						Weight = "48.1 kg",
						Height = "163.1 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "108 / 81 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("4-13-2020"),
						Modified = DateTime.Parse("4-13-2020"),
						CreatedBy = "Lanny Blick",
						ModifiedBy = "Lanny Blick",
						PatientId = 57
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-31-2020"),
						Weight = "27 kg",
						Height = "132.5 cm",
						Temperature = "39.2 Cel",
						BloodPressure = "131 / 77 mm[Hg]",
						Pulse = "81",
						Created = DateTime.Parse("8-31-2020"),
						Modified = DateTime.Parse("8-31-2020"),
						CreatedBy = "David Tillman",
						ModifiedBy = "David Tillman",
						PatientId = 58
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-18-2020"),
						Weight = "52 kg",
						Height = "166.1 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "127 / 86 mm[Hg]",
						Pulse = "95",
						Created = DateTime.Parse("6-18-2020"),
						Modified = DateTime.Parse("6-18-2020"),
						CreatedBy = "Santos Ernser",
						ModifiedBy = "Santos Ernser",
						PatientId = 59
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-16-2020"),
						Weight = "27.3 kg",
						Height = "132.9 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "130 / 83 mm[Hg]",
						Pulse = "76",
						Created = DateTime.Parse("8-16-2020"),
						Modified = DateTime.Parse("8-16-2020"),
						CreatedBy = "Joi Daugherty",
						ModifiedBy = "Joi Daugherty",
						PatientId = 60
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-2-2020"),
						Weight = "102.9 kg",
						Height = "187.1 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "108 / 77 mm[Hg]",
						Pulse = "86",
						Created = DateTime.Parse("2-2-2020"),
						Modified = DateTime.Parse("2-2-2020"),
						CreatedBy = "Gaylord McCullough",
						ModifiedBy = "Gaylord McCullough",
						PatientId = 61
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-7-2020"),
						Weight = "30.5 kg",
						Height = "137.5 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "106 / 76 mm[Hg]",
						Pulse = "76",
						Created = DateTime.Parse("12-7-2020"),
						Modified = DateTime.Parse("12-7-2020"),
						CreatedBy = "Genevieve Stiedemann",
						ModifiedBy = "Genevieve Stiedemann",
						PatientId = 62
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-20-2019"),
						Weight = "54.5 kg",
						Height = "167.4 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "128 / 78 mm[Hg]",
						Pulse = "88",
						Created = DateTime.Parse("8-20-2019"),
						Modified = DateTime.Parse("8-20-2019"),
						CreatedBy = "Monte Bergstrom",
						ModifiedBy = "Monte Bergstrom",
						PatientId = 63
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-15-2019"),
						Weight = "56.2 kg",
						Height = "168 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "138 / 86 mm[Hg]",
						Pulse = "86",
						Created = DateTime.Parse("9-15-2019"),
						Modified = DateTime.Parse("9-15-2019"),
						CreatedBy = "Noelia Morissette",
						ModifiedBy = "Noelia Morissette",
						PatientId = 64
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-11-2019"),
						Weight = "3.6 kg",
						Height = "49.9 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "133 / 77 mm[Hg]",
						Pulse = "86",
						Created = DateTime.Parse("10-11-2019"),
						Modified = DateTime.Parse("10-11-2019"),
						CreatedBy = "Colin Yundt",
						ModifiedBy = "Colin Yundt",
						PatientId = 65
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-20-2019"),
						Weight = "4.5 kg",
						Height = "53.9 cm",
						Temperature = "37 Cel",
						BloodPressure = "111 / 72 mm[Hg]",
						Pulse = "70",
						Created = DateTime.Parse("8-20-2019"),
						Modified = DateTime.Parse("8-20-2019"),
						CreatedBy = "Adrian Johns",
						ModifiedBy = "Adrian Johns",
						PatientId = 66
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-6-2019"),
						Weight = "5.9 kg",
						Height = "59.4 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "121 / 74 mm[Hg]",
						Pulse = "94",
						Created = DateTime.Parse("10-6-2019"),
						Modified = DateTime.Parse("10-6-2019"),
						CreatedBy = "Charmaine Hoeger",
						ModifiedBy = "Charmaine Hoeger",
						PatientId = 67
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-12-2020"),
						Weight = "7.1 kg",
						Height = "63.4 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "130 / 74 mm[Hg]",
						Pulse = "84",
						Created = DateTime.Parse("12-12-2020"),
						Modified = DateTime.Parse("12-12-2020"),
						CreatedBy = "Kory Ernser",
						ModifiedBy = "Kory Ernser",
						PatientId = 68
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-29-2020"),
						Weight = "8.5 kg",
						Height = "68 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "132 / 75 mm[Hg]",
						Pulse = "69",
						Created = DateTime.Parse("8-29-2020"),
						Modified = DateTime.Parse("8-29-2020"),
						CreatedBy = "Rudy Kerluke",
						ModifiedBy = "Rudy Kerluke",
						PatientId = 69
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-13-2019"),
						Weight = "24 kg",
						Height = "119.3 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "126 / 78 mm[Hg]",
						Pulse = "96",
						Created = DateTime.Parse("8-13-2019"),
						Modified = DateTime.Parse("8-13-2019"),
						CreatedBy = "Mike Moore",
						ModifiedBy = "Mike Moore",
						PatientId = 70
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-7-2020"),
						Weight = "27.1 kg",
						Height = "126.1 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "123 / 74 mm[Hg]",
						Pulse = "66",
						Created = DateTime.Parse("9-7-2020"),
						Modified = DateTime.Parse("9-7-2020"),
						CreatedBy = "Brice Mitchell",
						ModifiedBy = "Brice Mitchell",
						PatientId = 71
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-19-2020"),
						Weight = "30.5 kg",
						Height = "132.5 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "135 / 80 mm[Hg]",
						Pulse = "91",
						Created = DateTime.Parse("4-19-2020"),
						Modified = DateTime.Parse("4-19-2020"),
						CreatedBy = "Olin Zulauf",
						ModifiedBy = "Olin Zulauf",
						PatientId = 72
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-18-2020"),
						Weight = "34.8 kg",
						Height = "139 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "130 / 80 mm[Hg]",
						Pulse = "60",
						Created = DateTime.Parse("5-18-2020"),
						Modified = DateTime.Parse("5-18-2020"),
						CreatedBy = "Renata Walter",
						ModifiedBy = "Renata Walter",
						PatientId = 73
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-26-2019"),
						Weight = "39.5 kg",
						Height = "144.5 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "130 / 75 mm[Hg]",
						Pulse = "68",
						Created = DateTime.Parse("6-26-2019"),
						Modified = DateTime.Parse("6-26-2019"),
						CreatedBy = "Susana Lockman",
						ModifiedBy = "Susana Lockman",
						PatientId = 74
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-7-2019"),
						Weight = "44.8 kg",
						Height = "149.7 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "126 / 78 mm[Hg]",
						Pulse = "85",
						Created = DateTime.Parse("4-7-2019"),
						Modified = DateTime.Parse("4-7-2019"),
						CreatedBy = "Hee Hagenes",
						ModifiedBy = "Hee Hagenes",
						PatientId = 75
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-11-2020"),
						Weight = "50.7 kg",
						Height = "155.7 cm",
						Temperature = "37.6 Cel",
						BloodPressure = "103 / 75 mm[Hg]",
						Pulse = "83",
						Created = DateTime.Parse("12-11-2020"),
						Modified = DateTime.Parse("12-11-2020"),
						CreatedBy = "Tod Rice",
						ModifiedBy = "Tod Rice",
						PatientId = 76
					},
				new Vital
					{
						VitalDate = DateTime.Parse("8-27-2020"),
						Weight = "56.9 kg",
						Height = "163.1 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "124 / 79 mm[Hg]",
						Pulse = "88",
						Created = DateTime.Parse("8-27-2020"),
						Modified = DateTime.Parse("8-27-2020"),
						CreatedBy = "Ceola Bogisich",
						ModifiedBy = "Ceola Bogisich",
						PatientId = 77
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-7-2020"),
						Weight = "63.6 kg",
						Height = "171.4 cm",
						Temperature = "37.2 Cel",
						BloodPressure = "120 / 82 mm[Hg]",
						Pulse = "70",
						Created = DateTime.Parse("4-7-2020"),
						Modified = DateTime.Parse("4-7-2020"),
						CreatedBy = "Clay Johns",
						ModifiedBy = "Clay Johns",
						PatientId = 78
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-10-2019"),
						Weight = "69.4 kg",
						Height = "176.9 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "118 / 81 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("2-10-2019"),
						Modified = DateTime.Parse("2-10-2019"),
						CreatedBy = "Maribel Bogisich",
						ModifiedBy = "Maribel Bogisich",
						PatientId = 79
					},
				new Vital
					{
						VitalDate = DateTime.Parse("9-2-2020"),
						Weight = "41.8 kg",
						Height = "161.4 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "101 / 81 mm[Hg]",
						Pulse = "85",
						Created = DateTime.Parse("9-2-2020"),
						Modified = DateTime.Parse("9-2-2020"),
						CreatedBy = "Veronica Hermiston",
						ModifiedBy = "Veronica Hermiston",
						PatientId = 80
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-8-2019"),
						Weight = "45.4 kg",
						Height = "164.5 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "119 / 83 mm[Hg]",
						Pulse = "81",
						Created = DateTime.Parse("6-8-2019"),
						Modified = DateTime.Parse("6-8-2019"),
						CreatedBy = "Latricia Bailey",
						ModifiedBy = "Latricia Bailey",
						PatientId = 81
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-13-2019"),
						Weight = "48.1 kg",
						Height = "165.8 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "133 / 83 mm[Hg]",
						Pulse = "65",
						Created = DateTime.Parse("5-13-2019"),
						Modified = DateTime.Parse("5-13-2019"),
						CreatedBy = "Miguel a?ngel Romo",
						ModifiedBy = "Miguel a?ngel Romo",
						PatientId = 82
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-18-2019"),
						Weight = "49.9 kg",
						Height = "166.4 cm",
						Temperature = "37.5 Cel",
						BloodPressure = "116 / 78 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("4-18-2019"),
						Modified = DateTime.Parse("4-18-2019"),
						CreatedBy = "Ada?n Valdaes",
						ModifiedBy = "Ada?n Valdaes",
						PatientId = 83
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-10-2019"),
						Weight = "51.2 kg",
						Height = "166.8 cm",
						Temperature = "37 Cel",
						BloodPressure = "100 / 72 mm[Hg]",
						Pulse = "87",
						Created = DateTime.Parse("2-10-2019"),
						Modified = DateTime.Parse("2-10-2019"),
						CreatedBy = "Noble Hodkiewicz",
						ModifiedBy = "Noble Hodkiewicz",
						PatientId = 84
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-4-2019"),
						Weight = "52.2 kg",
						Height = "167 cm",
						Temperature = "37.5 Cel",
						BloodPressure = "134 / 87 mm[Hg]",
						Pulse = "63",
						Created = DateTime.Parse("2-4-2019"),
						Modified = DateTime.Parse("2-4-2019"),
						CreatedBy = "Bettye Gleichner",
						ModifiedBy = "Bettye Gleichner",
						PatientId = 85
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-5-2020"),
						Weight = "53.2 kg",
						Height = "167.1 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "137 / 71 mm[Hg]",
						Pulse = "61",
						Created = DateTime.Parse("11-5-2020"),
						Modified = DateTime.Parse("11-5-2020"),
						CreatedBy = "Gerardo Crooks",
						ModifiedBy = "Gerardo Crooks",
						PatientId = 86
					},
				new Vital
					{
						VitalDate = DateTime.Parse("6-1-2020"),
						Weight = "57 kg",
						Height = "167.2 cm",
						Temperature = "37.3 Cel",
						BloodPressure = "104 / 73 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("6-1-2020"),
						Modified = DateTime.Parse("6-1-2020"),
						CreatedBy = "Donita Pfeffer",
						ModifiedBy = "Donita Pfeffer",
						PatientId = 87
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-26-2020"),
						Weight = "9.5 kg",
						Height = "78.1 cm",
						Temperature = "37.1 Cel",
						BloodPressure = "108 / 77 mm[Hg]",
						Pulse = "82",
						Created = DateTime.Parse("11-26-2020"),
						Modified = DateTime.Parse("11-26-2020"),
						CreatedBy = "Fransisca Emmerich",
						ModifiedBy = "Fransisca Emmerich",
						PatientId = 88
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-30-2019"),
						Weight = "10.1 kg",
						Height = "81.3 cm",
						Temperature = "37.4 Cel",
						BloodPressure = "129 / 85 mm[Hg]",
						Pulse = "77",
						Created = DateTime.Parse("11-30-2019"),
						Modified = DateTime.Parse("11-30-2019"),
						CreatedBy = "Tod Rice",
						ModifiedBy = "Tod Rice",
						PatientId = 89
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-18-2019"),
						Weight = "11.1 kg",
						Height = "87 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "129 / 75 mm[Hg]",
						Pulse = "87",
						Created = DateTime.Parse("11-18-2019"),
						Modified = DateTime.Parse("11-18-2019"),
						CreatedBy = "Jayson Swift",
						ModifiedBy = "Jayson Swift",
						PatientId = 90
					},
				new Vital
					{
						VitalDate = DateTime.Parse("4-5-2020"),
						Weight = "11.9 kg",
						Height = "91.4 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "109 / 75 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("4-5-2020"),
						Modified = DateTime.Parse("4-5-2020"),
						CreatedBy = "Kasey Spencer",
						ModifiedBy = "Kasey Spencer",
						PatientId = 91
					},
				new Vital
					{
						VitalDate = DateTime.Parse("11-21-2020"),
						Weight = "12.7 kg",
						Height = "95.5 cm",
						Temperature = "37.5 Cel",
						BloodPressure = "106 / 84 mm[Hg]",
						Pulse = "83",
						Created = DateTime.Parse("11-21-2020"),
						Modified = DateTime.Parse("11-21-2020"),
						CreatedBy = "Jazmin Schultz",
						ModifiedBy = "Jazmin Schultz",
						PatientId = 92
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-12-2020"),
						Weight = "13.5 kg",
						Height = "99 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "114 / 79 mm[Hg]",
						Pulse = "73",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("2-12-2020"),
						CreatedBy = "Rick Boyer",
						ModifiedBy = "Rick Boyer",
						PatientId = 93
					},
				new Vital
					{
						VitalDate = DateTime.Parse("12-16-2019"),
						Weight = "14.4 kg",
						Height = "102.5 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "118 / 84 mm[Hg]",
						Pulse = "62",
						Created = DateTime.Parse("12-16-2019"),
						Modified = DateTime.Parse("12-16-2019"),
						CreatedBy = "Jame Johnson",
						ModifiedBy = "Jame Johnson",
						PatientId = 94
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-11-2020"),
						Weight = "16.2 kg",
						Height = "109.6 cm",
						Temperature = "37 Cel",
						BloodPressure = "117 / 74 mm[Hg]",
						Pulse = "92",
						Created = DateTime.Parse("10-11-2020"),
						Modified = DateTime.Parse("10-11-2020"),
						CreatedBy = "Cruz Green",
						ModifiedBy = "Cruz Green",
						PatientId = 95
					},
				new Vital
					{
						VitalDate = DateTime.Parse("5-3-2019"),
						Weight = "18.2 kg",
						Height = "116.9 cm",
						Temperature = "37 Cel",
						BloodPressure = "112 / 84 mm[Hg]",
						Pulse = "76",
						Created = DateTime.Parse("5-3-2019"),
						Modified = DateTime.Parse("5-3-2019"),
						CreatedBy = "Leonard Bechtelar",
						ModifiedBy = "Leonard Bechtelar",
						PatientId = 96
					},
				new Vital
					{
						VitalDate = DateTime.Parse("2-15-2019"),
						Weight = "20.3 kg",
						Height = "123.9 cm",
						Temperature = "37.7 Cel",
						BloodPressure = "118 / 86 mm[Hg]",
						Pulse = "64",
						Created = DateTime.Parse("2-15-2019"),
						Modified = DateTime.Parse("2-15-2019"),
						CreatedBy = "Sanjuana Heaney",
						ModifiedBy = "Sanjuana Heaney",
						PatientId = 97
					},
				new Vital
					{
						VitalDate = DateTime.Parse("3-8-2019"),
						Weight = "22.7 kg",
						Height = "130.1 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "109 / 76 mm[Hg]",
						Pulse = "90",
						Created = DateTime.Parse("3-8-2019"),
						Modified = DateTime.Parse("3-8-2019"),
						CreatedBy = "Janessa Zieme",
						ModifiedBy = "Janessa Zieme",
						PatientId = 98
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-31-2020"),
						Weight = "25.7 kg",
						Height = "136.1 cm",
						Temperature = "37.8 Cel",
						BloodPressure = "118 / 72 mm[Hg]",
						Pulse = "74",
						Created = DateTime.Parse("10-31-2020"),
						Modified = DateTime.Parse("10-31-2020"),
						CreatedBy = "Louis Hettinger",
						ModifiedBy = "Louis Hettinger",
						PatientId = 99
					},
				new Vital
					{
						VitalDate = DateTime.Parse("10-31-2020"),
						Weight = "28.9 kg",
						Height = "141.4 cm",
						Temperature = "37.9 Cel",
						BloodPressure = "119 / 81 mm[Hg]",
						Pulse = "66",
						Created = DateTime.Parse("10-31-2020"),
						Modified = DateTime.Parse("10-31-2020"),
						CreatedBy = "Alica Reinger",
						ModifiedBy = "Alica Reinger",
						PatientId = 100
					}
				};

			vitals.ForEach(v => context.Vitals.AddOrUpdate(v));
			context.SaveChanges();

			if (context.Treatments.Any())
				{
				return;
				}

			var treatments = new List<Treatment>
			{
								new Treatment
					{
						TreatmentDate = DateTime.Parse("3-17-2019"),
						TreatDescription = "Antenatal RhD antibody screening",
						Created = DateTime.Parse("5-10-2019"),
						Modified = DateTime.Parse("8-29-2019"),
						CreatedBy = "Ricky Gorczany",
						ModifiedBy = "Rico Gutkowski",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-22-2020"),
						TreatDescription = "Renal dialysis (procedure)",
						Created = DateTime.Parse("9-19-2020"),
						Modified = DateTime.Parse("12-10-2020"),
						CreatedBy = "Georgeann Corkery",
						ModifiedBy = "Thersa Aufderhar",
						PatientId = 10
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-14-2019"),
						TreatDescription = "Medical induction of labor",
						Created = DateTime.Parse("3-23-2019"),
						Modified = DateTime.Parse("7-4-2019"),
						CreatedBy = "Herna¡n Rodra­gez",
						ModifiedBy = "Matthew Adams",
						PatientId = 70
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-1-2020"),
						TreatDescription = "Induced termination of pregnancy",
						Created = DateTime.Parse("10-28-2019"),
						Modified = DateTime.Parse("1-8-2020"),
						CreatedBy = "Prince Ondricka",
						ModifiedBy = "Manuela Mua±oz",
						PatientId = 92
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-8-2019"),
						TreatDescription = "Seizure Count Cerebral Cortex Electroencephalogram (EEG)",
						Created = DateTime.Parse("8-14-2019"),
						Modified = DateTime.Parse("10-6-2019"),
						CreatedBy = "Dean Lynch",
						ModifiedBy = "Emma Hettinger",
						PatientId = 13
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-16-2020"),
						TreatDescription = "Information gathering (procedure)",
						Created = DateTime.Parse("10-11-2020"),
						Modified = DateTime.Parse("1-7-2021"),
						CreatedBy = "Monte Welch",
						ModifiedBy = "Fernando Caraballo",
						PatientId = 7
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-19-2020"),
						TreatDescription = "Ultrasonography of bilateral breasts (procedure)",
						Created = DateTime.Parse("1-13-2021"),
						Modified = DateTime.Parse("2-21-2021"),
						CreatedBy = "Joseph Effertz",
						ModifiedBy = "Alma Hessel",
						PatientId = 78
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-14-2020"),
						TreatDescription = "Episiotomy",
						Created = DateTime.Parse("5-17-2020"),
						Modified = DateTime.Parse("8-14-2020"),
						CreatedBy = "Rosanne Mills",
						ModifiedBy = "Derek Hickle",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-27-2020"),
						TreatDescription = "Partial resection of colon",
						Created = DateTime.Parse("1-18-2021"),
						Modified = DateTime.Parse("4-1-2021"),
						CreatedBy = "Nathanael Abernathy",
						ModifiedBy = "Lorenzo Rempel",
						PatientId = 72
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-30-2020"),
						TreatDescription = "Childbirth",
						Created = DateTime.Parse("1-23-2021"),
						Modified = DateTime.Parse("3-11-2021"),
						CreatedBy = "Florentino Jakubowski",
						ModifiedBy = "Tiana Hoeger",
						PatientId = 88
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-23-2020"),
						TreatDescription = "Chlamydia antigen test",
						Created = DateTime.Parse("11-4-2020"),
						Modified = DateTime.Parse("12-14-2020"),
						CreatedBy = "Nola Emard",
						ModifiedBy = "Elyse D'Amore",
						PatientId = 69
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-10-2020"),
						TreatDescription = "Intramuscular injection",
						Created = DateTime.Parse("5-20-2020"),
						Modified = DateTime.Parse("7-14-2020"),
						CreatedBy = "Frankie Sawayn",
						ModifiedBy = "Randell Hodkiewicz",
						PatientId = 20
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-5-2020"),
						TreatDescription = "Evaluation of uterine fundal height",
						Created = DateTime.Parse("12-20-2020"),
						Modified = DateTime.Parse("3-10-2021"),
						CreatedBy = "Jaime Luevano",
						ModifiedBy = "Jennette McGlynn",
						PatientId = 37
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-25-2019"),
						TreatDescription = "High resolution computed tomography of chest without contrast (procedure)",
						Created = DateTime.Parse("2-10-2020"),
						Modified = DateTime.Parse("3-16-2020"),
						CreatedBy = "Tristan Spencer",
						ModifiedBy = "Isiah Jakubowski",
						PatientId = 65
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-8-2019"),
						TreatDescription = "Replacement of contraceptive intrauterine device",
						Created = DateTime.Parse("2-27-2020"),
						Modified = DateTime.Parse("6-24-2020"),
						CreatedBy = "Cora Lockman",
						ModifiedBy = "Eusebia Reilly",
						PatientId = 42
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-26-2020"),
						TreatDescription = "Bilateral tubal ligation",
						Created = DateTime.Parse("1-17-2021"),
						Modified = DateTime.Parse("5-7-2021"),
						CreatedBy = "Ignacia Little",
						ModifiedBy = "Willie Moen",
						PatientId = 11
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-5-2020"),
						TreatDescription = "Injection of tetanus antitoxin",
						Created = DateTime.Parse("9-5-2020"),
						Modified = DateTime.Parse("10-18-2020"),
						CreatedBy = "Emmitt Auer",
						ModifiedBy = "Dusti Lindgren",
						PatientId = 1
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-29-2020"),
						TreatDescription = "Hearing examination (procedure)",
						Created = DateTime.Parse("8-5-2020"),
						Modified = DateTime.Parse("10-3-2020"),
						CreatedBy = "Maricarmen Loya",
						ModifiedBy = "Basil Grimes",
						PatientId = 89
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-29-2020"),
						TreatDescription = "Teleradiotherapy procedure (procedure)",
						Created = DateTime.Parse("8-26-2020"),
						Modified = DateTime.Parse("10-26-2020"),
						CreatedBy = "Carmen Sierra",
						ModifiedBy = "Vance Kling",
						PatientId = 30
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-14-2019"),
						TreatDescription = "Magnetic resonance imaging of breast (procedure)",
						Created = DateTime.Parse("12-26-2019"),
						Modified = DateTime.Parse("4-2-2020"),
						CreatedBy = "Alycia Barrows",
						ModifiedBy = "Rickie Abshire",
						PatientId = 39
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-31-2020"),
						TreatDescription = "Vaccination for diphtheria  pertussis  and tetanus",
						Created = DateTime.Parse("11-23-2020"),
						Modified = DateTime.Parse("3-21-2021"),
						CreatedBy = "Sal Hermann",
						ModifiedBy = "Judy Pollich",
						PatientId = 99
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-13-2020"),
						TreatDescription = "Mammogram - symptomatic (procedure)",
						Created = DateTime.Parse("9-17-2020"),
						Modified = DateTime.Parse("1-1-2021"),
						CreatedBy = "Eleanora Swift",
						ModifiedBy = "Salvador Boyer",
						PatientId = 58
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-1-2019"),
						TreatDescription = "Screening for chromosomal aneuploidy in prenatal amniotic fluid",
						Created = DateTime.Parse("11-6-2019"),
						Modified = DateTime.Parse("1-16-2020"),
						CreatedBy = "Theda Frami",
						ModifiedBy = "Cheryle Ziemann",
						PatientId = 34
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-4-2019"),
						TreatDescription = "Construction of diverting colostomy",
						Created = DateTime.Parse("1-1-2020"),
						Modified = DateTime.Parse("3-19-2020"),
						CreatedBy = "Daniel Murray",
						ModifiedBy = "Carlita Gutkowski",
						PatientId = 72
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-16-2019"),
						TreatDescription = "Human immunodeficiency virus antigen test",
						Created = DateTime.Parse("12-2-2019"),
						Modified = DateTime.Parse("3-29-2020"),
						CreatedBy = "Mervin Romaguera",
						ModifiedBy = "Frankie Bernhard",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-6-2020"),
						TreatDescription = "Throat culture (procedure)",
						Created = DateTime.Parse("12-9-2020"),
						Modified = DateTime.Parse("3-25-2021"),
						CreatedBy = "Bud Berge",
						ModifiedBy = "Stuart Jones",
						PatientId = 74
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-23-2020"),
						TreatDescription = "Plain chest X-ray",
						Created = DateTime.Parse("5-5-2020"),
						Modified = DateTime.Parse("8-29-2020"),
						CreatedBy = "Sherrill Kilback",
						ModifiedBy = "Billie O'Hara",
						PatientId = 95
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-1-2019"),
						TreatDescription = "Transthoracic three dimensional ultrasonography of heart (procedure)",
						Created = DateTime.Parse("10-12-2019"),
						Modified = DateTime.Parse("1-11-2020"),
						CreatedBy = "Allegra Herman",
						ModifiedBy = "Andrew Erdman",
						PatientId = 21
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-17-2020"),
						TreatDescription = "Epidural anesthesia",
						Created = DateTime.Parse("12-2-2020"),
						Modified = DateTime.Parse("3-11-2021"),
						CreatedBy = "Mohammed Leuschke",
						ModifiedBy = "Evangeline Goldner",
						PatientId = 73
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-29-2019"),
						TreatDescription = "Physical examination of mother",
						Created = DateTime.Parse("3-13-2020"),
						Modified = DateTime.Parse("6-16-2020"),
						CreatedBy = "Nevada Waelchi",
						ModifiedBy = "Patrick Gusikowski",
						PatientId = 78
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-30-2020"),
						TreatDescription = "Removal of intrauterine device",
						Created = DateTime.Parse("10-29-2020"),
						Modified = DateTime.Parse("1-30-2021"),
						CreatedBy = "Alva Kiehn",
						ModifiedBy = "Ben O'Reilly",
						PatientId = 35
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-8-2019"),
						TreatDescription = "Bone density scan (procedure)",
						Created = DateTime.Parse("12-6-2019"),
						Modified = DateTime.Parse("2-5-2020"),
						CreatedBy = "Quintin Tillman",
						ModifiedBy = "Davis Wolf",
						PatientId = 50
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-30-2020"),
						TreatDescription = "Insertion of biventricular implantable cardioverter defibrillator",
						Created = DateTime.Parse("8-28-2020"),
						Modified = DateTime.Parse("10-9-2020"),
						CreatedBy = "Darin Hermiston",
						ModifiedBy = "Fidel Runolfsdottir",
						PatientId = 69
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-18-2019"),
						TreatDescription = "Depression screening",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("12-12-2019"),
						CreatedBy = "Rolf Gottlieb",
						ModifiedBy = "Sonia Rael",
						PatientId = 25
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-14-2020"),
						TreatDescription = "Measurement of respiratory function (procedure)",
						Created = DateTime.Parse("7-19-2020"),
						Modified = DateTime.Parse("10-22-2020"),
						CreatedBy = "Cameron Emard",
						ModifiedBy = "Greg Bernier",
						PatientId = 97
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-14-2020"),
						TreatDescription = "Induced termination of pregnancy",
						Created = DateTime.Parse("7-24-2020"),
						Modified = DateTime.Parse("10-24-2020"),
						CreatedBy = "Terry Huel",
						ModifiedBy = "Bertram Kilback",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-26-2019"),
						TreatDescription = "Urine screening for glucose",
						Created = DateTime.Parse("10-5-2019"),
						Modified = DateTime.Parse("1-26-2020"),
						CreatedBy = "Jonah Kemmer",
						ModifiedBy = "Michel Harvey",
						PatientId = 81
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-20-2019"),
						TreatDescription = "Standard pregnancy test",
						Created = DateTime.Parse("4-24-2019"),
						Modified = DateTime.Parse("5-27-2019"),
						CreatedBy = "Myriam Tromp",
						ModifiedBy = "Lamar Streich",
						PatientId = 6
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-3-2019"),
						TreatDescription = "Cognitive and behavioral therapy",
						Created = DateTime.Parse("2-11-2019"),
						Modified = DateTime.Parse("4-16-2019"),
						CreatedBy = "Clark Runolfsson",
						ModifiedBy = "Alesha Ward",
						PatientId = 66
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-6-2019"),
						TreatDescription = "Instrumental delivery",
						Created = DateTime.Parse("9-5-2019"),
						Modified = DateTime.Parse("12-19-2019"),
						CreatedBy = "Rudolf Purdy",
						ModifiedBy = "Huey Herman",
						PatientId = 38
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-27-2020"),
						TreatDescription = "Hepatitis C antibody test",
						Created = DateTime.Parse("11-17-2020"),
						Modified = DateTime.Parse("3-2-2021"),
						CreatedBy = "Tawny Bauch",
						ModifiedBy = "Linwood Kub",
						PatientId = 61
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-15-2019"),
						TreatDescription = "Fecal occult blood test",
						Created = DateTime.Parse("11-26-2019"),
						Modified = DateTime.Parse("1-26-2020"),
						CreatedBy = "Elmo Wunsch",
						ModifiedBy = "Tajuana Upton",
						PatientId = 42
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-7-2020"),
						TreatDescription = "Echocardiography (procedure)",
						Created = DateTime.Parse("3-6-2021"),
						Modified = DateTime.Parse("5-3-2021"),
						CreatedBy = "Reatha Kunze",
						ModifiedBy = "America Macejkovic",
						PatientId = 21
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-5-2019"),
						TreatDescription = "Chemotherapy (procedure)",
						Created = DateTime.Parse("9-14-2019"),
						Modified = DateTime.Parse("12-6-2019"),
						CreatedBy = "Thersa Aufderhar",
						ModifiedBy = "Sherlyn Hamill",
						PatientId = 30
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-18-2019"),
						TreatDescription = "Computed tomography of chest and abdomen",
						Created = DateTime.Parse("9-18-2019"),
						Modified = DateTime.Parse("1-6-2020"),
						CreatedBy = "Bud Berge",
						ModifiedBy = "Jone Donnelly",
						PatientId = 70
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-24-2019"),
						TreatDescription = "Suicide risk assessment (procedure)",
						Created = DateTime.Parse("3-11-2020"),
						Modified = DateTime.Parse("4-20-2020"),
						CreatedBy = "Sidney Grant",
						ModifiedBy = "Fausto Cummings",
						PatientId = 8
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-7-2019"),
						TreatDescription = "Intravenous blood transfusion of packed cells (procedure)",
						Created = DateTime.Parse("6-1-2019"),
						Modified = DateTime.Parse("9-8-2019"),
						CreatedBy = "Damon Barrows",
						ModifiedBy = "Shira Klein",
						PatientId = 46
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-16-2020"),
						TreatDescription = "Laparoscopic Removal of Gall Bladder",
						Created = DateTime.Parse("5-9-2020"),
						Modified = DateTime.Parse("6-23-2020"),
						CreatedBy = "Jacobo Coronado",
						ModifiedBy = "Josae Mara­a Berra­os",
						PatientId = 41
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-17-2020"),
						TreatDescription = "Combined chemotherapy and radiation therapy (procedure)",
						Created = DateTime.Parse("3-16-2021"),
						Modified = DateTime.Parse("5-4-2021"),
						CreatedBy = "Stevie Homenick",
						ModifiedBy = "Lavern Grimes",
						PatientId = 8
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-26-2020"),
						TreatDescription = "Review of systems (procedure)",
						Created = DateTime.Parse("2-21-2021"),
						Modified = DateTime.Parse("4-5-2021"),
						CreatedBy = "Kiyoko Boehm",
						ModifiedBy = "Irish Schulist",
						PatientId = 86
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-31-2020"),
						TreatDescription = "Plain chest X-ray (procedure)",
						Created = DateTime.Parse("10-11-2020"),
						Modified = DateTime.Parse("1-27-2021"),
						CreatedBy = "Aubrey Schmitt",
						ModifiedBy = "Shenita Effertz",
						PatientId = 13
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-15-2020"),
						TreatDescription = "Vaccination for diphtheria  pertussis  and tetanus",
						Created = DateTime.Parse("10-6-2020"),
						Modified = DateTime.Parse("1-2-2021"),
						CreatedBy = "Fumiko Swift",
						ModifiedBy = "Grant Schaefer",
						PatientId = 32
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-6-2020"),
						TreatDescription = "Admission to trauma surgery department",
						Created = DateTime.Parse("8-9-2020"),
						Modified = DateTime.Parse("11-6-2020"),
						CreatedBy = "Antwan Hessel",
						ModifiedBy = "Cary Kirlin",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-30-2020"),
						TreatDescription = "Partial resection of colon",
						Created = DateTime.Parse("4-25-2020"),
						Modified = DateTime.Parse("8-10-2020"),
						CreatedBy = "Rosamaria Treutel",
						ModifiedBy = "Claude Walsh",
						PatientId = 87
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-20-2020"),
						TreatDescription = "Fecal occult blood test",
						Created = DateTime.Parse("3-13-2020"),
						Modified = DateTime.Parse("6-15-2020"),
						CreatedBy = "Lesli Sporer",
						ModifiedBy = "Walker Osinski",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-21-2020"),
						TreatDescription = "Bone immobilization",
						Created = DateTime.Parse("6-25-2020"),
						Modified = DateTime.Parse("10-12-2020"),
						CreatedBy = "Willie Brown",
						ModifiedBy = "Seema Purdy",
						PatientId = 33
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-23-2020"),
						TreatDescription = "Laparoscopic Removal of Gall Bladder",
						Created = DateTime.Parse("7-8-2020"),
						Modified = DateTime.Parse("8-25-2020"),
						CreatedBy = "Alton Schmitt",
						ModifiedBy = "Sumiko Bahringer",
						PatientId = 4
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-28-2019"),
						TreatDescription = "Extraction of wisdom tooth",
						Created = DateTime.Parse("4-12-2019"),
						Modified = DateTime.Parse("7-31-2019"),
						CreatedBy = "Cristopher Predovic",
						ModifiedBy = "Elfrieda McClure",
						PatientId = 75
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-22-2019"),
						TreatDescription = "Screening mammography (procedure)",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("12-30-2019"),
						CreatedBy = "Cameron Emard",
						ModifiedBy = "Micaela Rentera­a",
						PatientId = 50
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-10-2019"),
						TreatDescription = "Information gathering (procedure)",
						Created = DateTime.Parse("5-7-2019"),
						Modified = DateTime.Parse("8-3-2019"),
						CreatedBy = "Haywood Prosacco",
						ModifiedBy = "Margarite Pfannerstill",
						PatientId = 59
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-7-2020"),
						TreatDescription = "Physical examination",
						Created = DateTime.Parse("3-10-2020"),
						Modified = DateTime.Parse("5-17-2020"),
						CreatedBy = "Emilio Mraz",
						ModifiedBy = "Veola Bauch",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-25-2020"),
						TreatDescription = "Throat culture (procedure)",
						Created = DateTime.Parse("3-9-2021"),
						Modified = DateTime.Parse("6-4-2021"),
						CreatedBy = "Marilu Delapaz",
						ModifiedBy = "Leonel Wunsch",
						PatientId = 76
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-2-2020"),
						TreatDescription = "Rubella screening",
						Created = DateTime.Parse("9-21-2020"),
						Modified = DateTime.Parse("11-18-2020"),
						CreatedBy = "Diego Jenkins",
						ModifiedBy = "Santiago Reynolds",
						PatientId = 4
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-12-2019"),
						TreatDescription = "Review of systems (procedure)",
						Created = DateTime.Parse("10-14-2019"),
						Modified = DateTime.Parse("1-16-2020"),
						CreatedBy = "Sherley Upton",
						ModifiedBy = "Carolynn West",
						PatientId = 66
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Vasectomy",
						Created = DateTime.Parse("2-6-2021"),
						Modified = DateTime.Parse("5-27-2021"),
						CreatedBy = "Hue McKenzie",
						ModifiedBy = "Chet Lowe",
						PatientId = 56
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-29-2020"),
						TreatDescription = "Plain chest X-ray (procedure)",
						Created = DateTime.Parse("8-9-2020"),
						Modified = DateTime.Parse("11-2-2020"),
						CreatedBy = "Junie Ferry",
						ModifiedBy = "Hoa Wiegand",
						PatientId = 53
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-11-2020"),
						TreatDescription = "Premature birth of newborn",
						Created = DateTime.Parse("7-19-2020"),
						Modified = DateTime.Parse("8-27-2020"),
						CreatedBy = "Huey Herman",
						ModifiedBy = "Stepanie Grant",
						PatientId = 98
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-29-2020"),
						TreatDescription = "Bilateral tubal ligation",
						Created = DateTime.Parse("1-24-2021"),
						Modified = DateTime.Parse("3-17-2021"),
						CreatedBy = "Bebe Hauck",
						ModifiedBy = "Daron MacGyver",
						PatientId = 29
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-10-2019"),
						TreatDescription = "Transthoracic echocardiography",
						Created = DateTime.Parse("6-21-2019"),
						Modified = DateTime.Parse("9-6-2019"),
						CreatedBy = "Bambi Block",
						ModifiedBy = "Marcos Abrego",
						PatientId = 70
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-21-2019"),
						TreatDescription = "Catheter ablation of tissue of heart",
						Created = DateTime.Parse("11-3-2019"),
						Modified = DateTime.Parse("12-3-2019"),
						CreatedBy = "Rhett Hermiston",
						ModifiedBy = "Chery Bradtke",
						PatientId = 86
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-20-2020"),
						TreatDescription = "Review of systems (procedure)",
						Created = DateTime.Parse("1-26-2021"),
						Modified = DateTime.Parse("4-24-2021"),
						CreatedBy = "Brandy Haley",
						ModifiedBy = "Frank Thompson",
						PatientId = 17
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-10-2020"),
						TreatDescription = "Biopsy of breast (procedure)",
						Created = DateTime.Parse("6-23-2020"),
						Modified = DateTime.Parse("9-10-2020"),
						CreatedBy = "Lashaunda Koepp",
						ModifiedBy = "Nu Jast",
						PatientId = 44
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-19-2019"),
						TreatDescription = "Screening mammography (procedure)",
						Created = DateTime.Parse("6-13-2019"),
						Modified = DateTime.Parse("8-8-2019"),
						CreatedBy = "Jacquetta Thompson",
						ModifiedBy = "Marna Windler",
						PatientId = 51
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-7-2019"),
						TreatDescription = "Urine culture",
						Created = DateTime.Parse("10-7-2019"),
						Modified = DateTime.Parse("11-17-2019"),
						CreatedBy = "Paige Weber",
						ModifiedBy = "Zita Schaden",
						PatientId = 67
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-8-2020"),
						TreatDescription = "Syphilis infection test",
						Created = DateTime.Parse("2-17-2020"),
						Modified = DateTime.Parse("4-1-2020"),
						CreatedBy = "Gordon Trantow",
						ModifiedBy = "Lynsey Koelpin",
						PatientId = 33
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-5-2019"),
						TreatDescription = "Epidural anesthesia",
						Created = DateTime.Parse("8-8-2019"),
						Modified = DateTime.Parse("11-15-2019"),
						CreatedBy = "Lottie Watsica",
						ModifiedBy = "Dylan Hermiston",
						PatientId = 38
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-28-2020"),
						TreatDescription = "Allergy screening test",
						Created = DateTime.Parse("7-10-2020"),
						Modified = DateTime.Parse("10-5-2020"),
						CreatedBy = "Rubye Zulauf",
						ModifiedBy = "Jalisa O'Hara",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-20-2019"),
						TreatDescription = "Admission to trauma surgery department",
						Created = DateTime.Parse("12-21-2019"),
						Modified = DateTime.Parse("3-1-2020"),
						CreatedBy = "Glory Crist",
						ModifiedBy = "Rodrick Botsford",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-1-2019"),
						TreatDescription = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
						Created = DateTime.Parse("9-18-2019"),
						Modified = DateTime.Parse("12-5-2019"),
						CreatedBy = "Emilio Hand",
						ModifiedBy = "Mikel Dibbert",
						PatientId = 11
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-13-2020"),
						TreatDescription = "Streptococcus pneumoniae group B antigen test",
						Created = DateTime.Parse("2-24-2021"),
						Modified = DateTime.Parse("4-8-2021"),
						CreatedBy = "Irene Carmona",
						ModifiedBy = "Ricki Blick",
						PatientId = 37
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-1-2020"),
						TreatDescription = "Chlamydia antigen test",
						Created = DateTime.Parse("3-5-2020"),
						Modified = DateTime.Parse("5-21-2020"),
						CreatedBy = "Williams Stracke",
						ModifiedBy = "Una Hilpert",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-30-2019"),
						TreatDescription = "Teleradiotherapy procedure (procedure)",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("3-29-2020"),
						CreatedBy = "Shantelle Kuphal",
						ModifiedBy = "Abel Klein",
						PatientId = 35
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-13-2020"),
						TreatDescription = "Replacement of subcutaneous contraceptive",
						Created = DateTime.Parse("11-2-2020"),
						Modified = DateTime.Parse("2-10-2021"),
						CreatedBy = "Emma Hettinger",
						ModifiedBy = "Jeffry Daniel",
						PatientId = 55
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-6-2020"),
						TreatDescription = "Mammogram - symptomatic (procedure)",
						Created = DateTime.Parse("5-6-2020"),
						Modified = DateTime.Parse("6-11-2020"),
						CreatedBy = "Bernardine Erdman",
						ModifiedBy = "Quinton Cummerata",
						PatientId = 52
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-16-2019"),
						TreatDescription = "Evaluation of uterine fundal height",
						Created = DateTime.Parse("10-13-2019"),
						Modified = DateTime.Parse("1-4-2020"),
						CreatedBy = "Denver Christiansen",
						ModifiedBy = "Wendi Renner",
						PatientId = 78
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-9-2019"),
						TreatDescription = "Removal of intrauterine device",
						Created = DateTime.Parse("3-16-2019"),
						Modified = DateTime.Parse("5-3-2019"),
						CreatedBy = "Nelson Kirlin",
						ModifiedBy = "Andreas McClure",
						PatientId = 100
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-28-2020"),
						TreatDescription = "Urine screening for glucose",
						Created = DateTime.Parse("3-4-2021"),
						Modified = DateTime.Parse("6-7-2021"),
						CreatedBy = "Daniel Rael",
						ModifiedBy = "Laurice Schumm",
						PatientId = 13
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-7-2019"),
						TreatDescription = "Colonoscopy",
						Created = DateTime.Parse("2-6-2020"),
						Modified = DateTime.Parse("3-26-2020"),
						CreatedBy = "Alona Morissette",
						ModifiedBy = "Houston Bailey",
						PatientId = 92
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-22-2019"),
						TreatDescription = "Pelvis X-ray",
						Created = DateTime.Parse("1-8-2020"),
						Modified = DateTime.Parse("4-9-2020"),
						CreatedBy = "Zella Maggio",
						ModifiedBy = "Zonia O'Reilly",
						PatientId = 62
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-29-2019"),
						TreatDescription = "Blood typing  RH typing",
						Created = DateTime.Parse("11-16-2019"),
						Modified = DateTime.Parse("2-17-2020"),
						CreatedBy = "Adena Wilkinson",
						ModifiedBy = "Mammie Jacobson",
						PatientId = 100
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-24-2019"),
						TreatDescription = "Biopsy of prostate",
						Created = DateTime.Parse("6-17-2019"),
						Modified = DateTime.Parse("8-31-2019"),
						CreatedBy = "Guadalupe Sandoval",
						ModifiedBy = "Hester Bradtke",
						PatientId = 82
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-15-2019"),
						TreatDescription = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
						Created = DateTime.Parse("11-24-2019"),
						Modified = DateTime.Parse("3-7-2020"),
						CreatedBy = "Damian Pfannerstill",
						ModifiedBy = "Lelah Rolfson",
						PatientId = 48
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-3-2019"),
						TreatDescription = "Insertion of intrauterine contraceptive device",
						Created = DateTime.Parse("3-9-2019"),
						Modified = DateTime.Parse("4-23-2019"),
						CreatedBy = "Jayson Volkman",
						ModifiedBy = "Edmund Swaniawski",
						PatientId = 81
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-6-2020"),
						TreatDescription = "Replacement of contraceptive intrauterine device",
						Created = DateTime.Parse("9-23-2020"),
						Modified = DateTime.Parse("1-4-2021"),
						CreatedBy = "Wiley Stanton",
						ModifiedBy = "Felton Schaefer",
						PatientId = 35
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-12-2019"),
						TreatDescription = "Laparoscopic Removal of Gall Bladder",
						Created = DateTime.Parse("7-5-2019"),
						Modified = DateTime.Parse("10-28-2019"),
						CreatedBy = "Wyatt Strosin",
						ModifiedBy = "Meghann Murray",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-7-2020"),
						TreatDescription = "Syphilis infection test",
						Created = DateTime.Parse("7-22-2020"),
						Modified = DateTime.Parse("10-24-2020"),
						CreatedBy = "Dion Tromp",
						ModifiedBy = "Lakeisha Rogahn",
						PatientId = 73
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-25-2020"),
						TreatDescription = "Spirometry (procedure)",
						Created = DateTime.Parse("10-19-2020"),
						Modified = DateTime.Parse("1-19-2021"),
						CreatedBy = "Daebora Rosario",
						ModifiedBy = "Willard Heidenreich",
						PatientId = 61
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-13-2019"),
						TreatDescription = "Alpha-fetoprotein test",
						Created = DateTime.Parse("7-17-2019"),
						Modified = DateTime.Parse("10-9-2019"),
						CreatedBy = "Chance Moore",
						ModifiedBy = "Joycelyn Klein",
						PatientId = 32
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-22-2020"),
						TreatDescription = "X-ray or wrist",
						Created = DateTime.Parse("3-16-2020"),
						Modified = DateTime.Parse("7-12-2020"),
						CreatedBy = "Vicki Funk",
						ModifiedBy = "Alysa Ullrich",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-22-2019"),
						TreatDescription = "Excision of breast tissue (procedure)",
						Created = DateTime.Parse("12-19-2019"),
						Modified = DateTime.Parse("4-16-2020"),
						CreatedBy = "Shirlee Mayert",
						ModifiedBy = "Freeman Gusikowski",
						PatientId = 75
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-28-2019"),
						TreatDescription = "Peripheral blood smear interpretation",
						Created = DateTime.Parse("10-24-2019"),
						Modified = DateTime.Parse("1-30-2020"),
						CreatedBy = "Thanh Ratke",
						ModifiedBy = "Faustino West",
						PatientId = 26
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-25-2020"),
						TreatDescription = "Pelvis X-ray",
						Created = DateTime.Parse("7-9-2020"),
						Modified = DateTime.Parse("10-28-2020"),
						CreatedBy = "Billy Kovacek",
						ModifiedBy = "Clara Quintero",
						PatientId = 71
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-1-2020"),
						TreatDescription = "Coronary artery bypass grafting",
						Created = DateTime.Parse("11-3-2020"),
						Modified = DateTime.Parse("2-9-2021"),
						CreatedBy = "Karri Von",
						ModifiedBy = "Vaughn Howe",
						PatientId = 86
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-3-2020"),
						TreatDescription = "Antenatal RhD antibody screening",
						Created = DateTime.Parse("1-11-2021"),
						Modified = DateTime.Parse("3-5-2021"),
						CreatedBy = "Cruz Jenkins",
						ModifiedBy = "Charles Kovacek",
						PatientId = 18
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-28-2019"),
						TreatDescription = "Combined chemotherapy and radiation therapy (procedure)",
						Created = DateTime.Parse("1-26-2020"),
						Modified = DateTime.Parse("3-20-2020"),
						CreatedBy = "Arden Harris",
						ModifiedBy = "Gregorio Murazik",
						PatientId = 75
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-24-2020"),
						TreatDescription = "Replacement of contraceptive intrauterine device",
						Created = DateTime.Parse("7-16-2020"),
						Modified = DateTime.Parse("8-23-2020"),
						CreatedBy = "Donnette Cronin",
						ModifiedBy = "Riley McCullough",
						PatientId = 30
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-7-2020"),
						TreatDescription = "Fecal occult blood test",
						Created = DateTime.Parse("9-29-2020"),
						Modified = DateTime.Parse("1-18-2021"),
						CreatedBy = "Denver Christiansen",
						ModifiedBy = "Hans Lindgren",
						PatientId = 2
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-14-2019"),
						TreatDescription = "Instrumental delivery",
						Created = DateTime.Parse("5-24-2019"),
						Modified = DateTime.Parse("7-4-2019"),
						CreatedBy = "Maximo Deckow",
						ModifiedBy = "Stormy Bruen",
						PatientId = 46
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-16-2020"),
						TreatDescription = "Spontaneous breech delivery",
						Created = DateTime.Parse("1-10-2021"),
						Modified = DateTime.Parse("2-12-2021"),
						CreatedBy = "Von Kuhlman",
						ModifiedBy = "Berniece Leuschke",
						PatientId = 27
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-26-2019"),
						TreatDescription = "Human immunodeficiency virus antigen test",
						Created = DateTime.Parse("4-5-2020"),
						Modified = DateTime.Parse("8-3-2020"),
						CreatedBy = "Bernardine Greenholt",
						ModifiedBy = "Sindy Rogahn",
						PatientId = 3
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-3-2019"),
						TreatDescription = "Auscultation of the fetal heart",
						Created = DateTime.Parse("10-18-2019"),
						Modified = DateTime.Parse("11-19-2019"),
						CreatedBy = "Hugo Becker",
						ModifiedBy = "Phebe Runolfsson",
						PatientId = 24
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-2-2020"),
						TreatDescription = "Pregnancy termination care",
						Created = DateTime.Parse("4-15-2020"),
						Modified = DateTime.Parse("8-7-2020"),
						CreatedBy = "Doreatha Reinger",
						ModifiedBy = "Twanna Hilll",
						PatientId = 34
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Excision of breast tissue (procedure)",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("2-2-2021"),
						CreatedBy = "Lianne Bogisich",
						ModifiedBy = "Deandra Abernathy",
						PatientId = 48
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-4-2020"),
						TreatDescription = "Percutaneous mechanical thrombectomy of portal vein using fluoroscopic guidance",
						Created = DateTime.Parse("9-15-2020"),
						Modified = DateTime.Parse("11-6-2020"),
						CreatedBy = "Judson Waelchi",
						ModifiedBy = "Chauncey Bartoletti",
						PatientId = 67
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-6-2019"),
						TreatDescription = "Fetal anatomy study",
						Created = DateTime.Parse("4-12-2019"),
						Modified = DateTime.Parse("6-22-2019"),
						CreatedBy = "Loralee Herzog",
						ModifiedBy = "Consuela Crona",
						PatientId = 14
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-1-2020"),
						TreatDescription = "Extraction of wisdom tooth",
						Created = DateTime.Parse("12-18-2020"),
						Modified = DateTime.Parse("2-17-2021"),
						CreatedBy = "Amee Mertz",
						ModifiedBy = "Anglea Luettgen",
						PatientId = 34
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-14-2020"),
						TreatDescription = "Bilateral tubal ligation",
						Created = DateTime.Parse("2-5-2021"),
						Modified = DateTime.Parse("5-18-2021"),
						CreatedBy = "Dani Kulas",
						ModifiedBy = "Tish Trantow",
						PatientId = 12
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-3-2020"),
						TreatDescription = "Pregnancy termination care",
						Created = DateTime.Parse("3-9-2020"),
						Modified = DateTime.Parse("4-17-2020"),
						CreatedBy = "Lois Sipes",
						ModifiedBy = "Tuan Paucek",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-7-2019"),
						TreatDescription = "Human epidermal growth factor receptor 2 gene detection by fluorescence in situ hybridization (procedure)",
						Created = DateTime.Parse("8-26-2019"),
						Modified = DateTime.Parse("10-30-2019"),
						CreatedBy = "Una Hilpert",
						ModifiedBy = "Kemberly Hansen",
						PatientId = 20
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-30-2019"),
						TreatDescription = "Excision of fallopian tube and surgical removal of ectopic pregnancy",
						Created = DateTime.Parse("6-17-2019"),
						Modified = DateTime.Parse("7-26-2019"),
						CreatedBy = "Hal VonRueden",
						ModifiedBy = "Vanna Walker",
						PatientId = 19
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-23-2019"),
						TreatDescription = "Premature birth of newborn",
						Created = DateTime.Parse("1-30-2020"),
						Modified = DateTime.Parse("5-9-2020"),
						CreatedBy = "Breann Collins",
						ModifiedBy = "Margarite Pfannerstill",
						PatientId = 99
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-2-2020"),
						TreatDescription = "Pelvis X-ray",
						Created = DateTime.Parse("10-20-2020"),
						Modified = DateTime.Parse("1-21-2021"),
						CreatedBy = "Berta Duarte",
						ModifiedBy = "Ned Harris",
						PatientId = 66
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-26-2019"),
						TreatDescription = "Fetal anatomy study",
						Created = DateTime.Parse("5-28-2019"),
						Modified = DateTime.Parse("7-13-2019"),
						CreatedBy = "Yanira Mills",
						ModifiedBy = "Don Mertz",
						PatientId = 17
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-12-2019"),
						TreatDescription = "Biopsy of colon",
						Created = DateTime.Parse("9-22-2019"),
						Modified = DateTime.Parse("12-9-2019"),
						CreatedBy = "Antwan Hessel",
						ModifiedBy = "Bethanie Lesch",
						PatientId = 48
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-30-2019"),
						TreatDescription = "Skin test for tuberculosis",
						Created = DateTime.Parse("9-7-2019"),
						Modified = DateTime.Parse("12-12-2019"),
						CreatedBy = "Art Schneider",
						ModifiedBy = "Mose O'Conner",
						PatientId = 55
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-5-2020"),
						TreatDescription = "Depression screening using Patient Health Questionnaire Nine Item score (procedure)",
						Created = DateTime.Parse("8-6-2020"),
						Modified = DateTime.Parse("11-23-2020"),
						CreatedBy = "Carlo Gerlach",
						ModifiedBy = "Rocio Rosales",
						PatientId = 100
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-12-2020"),
						TreatDescription = "Ankle X-ray",
						Created = DateTime.Parse("4-9-2020"),
						Modified = DateTime.Parse("5-16-2020"),
						CreatedBy = "Yanira Mills",
						ModifiedBy = "Martina Eichmann",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-9-2020"),
						TreatDescription = "Admission to trauma surgery department",
						Created = DateTime.Parse("5-21-2020"),
						Modified = DateTime.Parse("8-14-2020"),
						CreatedBy = "Lynsey Koelpin",
						ModifiedBy = "Melida Hills",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-19-2019"),
						TreatDescription = "Augmentation of labor",
						Created = DateTime.Parse("1-3-2020"),
						Modified = DateTime.Parse("2-11-2020"),
						CreatedBy = "Ezekiel Wyman",
						ModifiedBy = "Inger Wolff",
						PatientId = 90
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-10-2020"),
						TreatDescription = "Excision of fallopian tube and surgical removal of ectopic pregnancy",
						Created = DateTime.Parse("4-8-2021"),
						Modified = DateTime.Parse("5-21-2021"),
						CreatedBy = "Oren Marvin",
						ModifiedBy = "Dudley Baumbach",
						PatientId = 32
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Vasectomy",
						Created = DateTime.Parse("12-26-2020"),
						Modified = DateTime.Parse("2-8-2021"),
						CreatedBy = "Tory Mills",
						ModifiedBy = "Anibal Gaylord",
						PatientId = 19
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-13-2020"),
						TreatDescription = "Thoracentesis (procedure)",
						Created = DateTime.Parse("6-23-2020"),
						Modified = DateTime.Parse("9-18-2020"),
						CreatedBy = "Ulrike Buckridge",
						ModifiedBy = "Ahmad Strosin",
						PatientId = 57
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-21-2020"),
						TreatDescription = "Cytopathology procedure  preparation of smear  genital source (procedure)",
						Created = DateTime.Parse("3-30-2020"),
						Modified = DateTime.Parse("5-9-2020"),
						CreatedBy = "Epifania Rogahn",
						ModifiedBy = "Adrianna Schoen",
						PatientId = 40
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-21-2019"),
						TreatDescription = "Episiotomy",
						Created = DateTime.Parse("9-17-2019"),
						Modified = DateTime.Parse("10-30-2019"),
						CreatedBy = "Sigrid Schowalter",
						ModifiedBy = "Guillermina Acua±a",
						PatientId = 71
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-12-2020"),
						TreatDescription = "Magnetic resonance imaging of breast (procedure)",
						Created = DateTime.Parse("2-24-2021"),
						Modified = DateTime.Parse("5-24-2021"),
						CreatedBy = "Oliver Barton",
						ModifiedBy = "Jene Boyer",
						PatientId = 80
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-16-2020"),
						TreatDescription = "RhD passive immunization",
						Created = DateTime.Parse("7-18-2020"),
						Modified = DateTime.Parse("9-23-2020"),
						CreatedBy = "Chelsie Dietrich",
						ModifiedBy = "Adena Wilkinson",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-7-2019"),
						TreatDescription = "Lung volume reduction surgery (procedure)",
						Created = DateTime.Parse("10-14-2019"),
						Modified = DateTime.Parse("12-16-2019"),
						CreatedBy = "Thomas Auer",
						ModifiedBy = "Suzi Fisher",
						PatientId = 33
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-26-2020"),
						TreatDescription = "Screening mammography (procedure)",
						Created = DateTime.Parse("10-3-2020"),
						Modified = DateTime.Parse("11-9-2020"),
						CreatedBy = "Ralph Barton",
						ModifiedBy = "Bok Mosciski",
						PatientId = 59
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-3-2019"),
						TreatDescription = "Urine screening test for diabetes",
						Created = DateTime.Parse("10-24-2019"),
						Modified = DateTime.Parse("12-22-2019"),
						CreatedBy = "Tonette Bode",
						ModifiedBy = "Ahmad Howell",
						PatientId = 74
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-7-2020"),
						TreatDescription = "Hearing examination (procedure)",
						Created = DateTime.Parse("6-20-2020"),
						Modified = DateTime.Parse("7-23-2020"),
						CreatedBy = "Maximo Medhurst",
						ModifiedBy = "Fernando Caraballo",
						PatientId = 18
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-8-2020"),
						TreatDescription = "Electrical cardioversion",
						Created = DateTime.Parse("3-6-2021"),
						Modified = DateTime.Parse("4-21-2021"),
						CreatedBy = "Elvis Rutherford",
						ModifiedBy = "Alline Klein",
						PatientId = 69
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-9-2019"),
						TreatDescription = "Diagnostic fiberoptic bronchoscopy (procedure)",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("11-20-2019"),
						CreatedBy = "Napoleon Kuhic",
						ModifiedBy = "An Bartoletti",
						PatientId = 43
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Review of systems (procedure)",
						Created = DateTime.Parse("11-17-2020"),
						Modified = DateTime.Parse("2-27-2021"),
						CreatedBy = "Daniel Zieme",
						ModifiedBy = "Roberto Montoya",
						PatientId = 95
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-18-2019"),
						TreatDescription = "Ultrasound scan for fetal viability",
						Created = DateTime.Parse("4-30-2019"),
						Modified = DateTime.Parse("6-29-2019"),
						CreatedBy = "Tresa Zulauf",
						ModifiedBy = "Daren Crooks",
						PatientId = 30
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-17-2019"),
						TreatDescription = "Depression screening",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("5-27-2020"),
						CreatedBy = "Will Smith",
						ModifiedBy = "Gerald Gerhold",
						PatientId = 68
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-24-2019"),
						TreatDescription = "Surgical manipulation of joint of knee",
						Created = DateTime.Parse("12-13-2019"),
						Modified = DateTime.Parse("2-17-2020"),
						CreatedBy = "Joana Wunsch",
						ModifiedBy = "Arthur Parker",
						PatientId = 51
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-17-2020"),
						TreatDescription = "Combined chemotherapy and radiation therapy (procedure)",
						Created = DateTime.Parse("10-2-2020"),
						Modified = DateTime.Parse("1-25-2021"),
						CreatedBy = "Damon Harber",
						ModifiedBy = "Dorthey Corwin",
						PatientId = 3
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-10-2019"),
						TreatDescription = "RhD passive immunization",
						Created = DateTime.Parse("3-4-2020"),
						Modified = DateTime.Parse("4-19-2020"),
						CreatedBy = "Damien Olson",
						ModifiedBy = "Faustino Auer",
						PatientId = 58
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-17-2020"),
						TreatDescription = "Premature birth of newborn",
						Created = DateTime.Parse("1-19-2021"),
						Modified = DateTime.Parse("3-6-2021"),
						CreatedBy = "Reuben Brown",
						ModifiedBy = "Bettie Rempel",
						PatientId = 7
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-17-2019"),
						TreatDescription = "Physical examination",
						Created = DateTime.Parse("4-18-2019"),
						Modified = DateTime.Parse("5-27-2019"),
						CreatedBy = "Lorelei Luettgen",
						ModifiedBy = "Jonah Schuppe",
						PatientId = 26
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-14-2020"),
						TreatDescription = "positive screening for PHQ-9",
						Created = DateTime.Parse("4-19-2020"),
						Modified = DateTime.Parse("6-19-2020"),
						CreatedBy = "Claudio Cisneros",
						ModifiedBy = "Erin Bartoletti",
						PatientId = 6
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-16-2020"),
						TreatDescription = "Removal of subcutaneous contraceptive",
						Created = DateTime.Parse("10-4-2020"),
						Modified = DateTime.Parse("11-7-2020"),
						CreatedBy = "Eva Roberts",
						ModifiedBy = "Lenard Gutmann",
						PatientId = 25
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-30-2019"),
						TreatDescription = "Echocardiography (procedure)",
						Created = DateTime.Parse("12-23-2019"),
						Modified = DateTime.Parse("3-20-2020"),
						CreatedBy = "Camellia Nader",
						ModifiedBy = "Halley Ziemann",
						PatientId = 77
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-17-2019"),
						TreatDescription = "Ankle X-ray",
						Created = DateTime.Parse("4-24-2019"),
						Modified = DateTime.Parse("6-16-2019"),
						CreatedBy = "Mariano Stiedemann",
						ModifiedBy = "Debi Paucek",
						PatientId = 93
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-1-2020"),
						TreatDescription = "Renal dialysis (procedure)",
						Created = DateTime.Parse("7-13-2020"),
						Modified = DateTime.Parse("9-12-2020"),
						CreatedBy = "Paz Hane",
						ModifiedBy = "Cleo Rogahn",
						PatientId = 21
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-12-2019"),
						TreatDescription = "Diagnostic fiberoptic bronchoscopy (procedure)",
						Created = DateTime.Parse("8-15-2019"),
						Modified = DateTime.Parse("11-28-2019"),
						CreatedBy = "Yoko Keeling",
						ModifiedBy = "Aleisha Deckow",
						PatientId = 89
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-25-2020"),
						TreatDescription = "Insertion of subcutaneous contraceptive",
						Created = DateTime.Parse("8-21-2020"),
						Modified = DateTime.Parse("10-30-2020"),
						CreatedBy = "Hollis Blanda",
						ModifiedBy = "James Kiehn",
						PatientId = 35
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-6-2020"),
						TreatDescription = "Excision of sentinel lymph node (procedure)",
						Created = DateTime.Parse("10-13-2020"),
						Modified = DateTime.Parse("12-4-2020"),
						CreatedBy = "Santiago Archuleta",
						ModifiedBy = "Alfredo Hickle",
						PatientId = 90
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-15-2019"),
						TreatDescription = "Admission to burn unit",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("4-7-2020"),
						CreatedBy = "Bok Mosciski",
						ModifiedBy = "Harrison Luettgen",
						PatientId = 69
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-23-2019"),
						TreatDescription = "Ankle X-ray",
						Created = DateTime.Parse("7-1-2019"),
						Modified = DateTime.Parse("10-26-2019"),
						CreatedBy = "Hiram Schulist",
						ModifiedBy = "Noelle Jenkins",
						PatientId = 92
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-29-2020"),
						TreatDescription = "Removal of intrauterine device",
						Created = DateTime.Parse("3-23-2021"),
						Modified = DateTime.Parse("4-22-2021"),
						CreatedBy = "Daphne Hyatt",
						ModifiedBy = "Laquanda Jenkins",
						PatientId = 71
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-15-2019"),
						TreatDescription = "Replacement of subcutaneous contraceptive",
						Created = DateTime.Parse("10-20-2019"),
						Modified = DateTime.Parse("1-12-2020"),
						CreatedBy = "Teodoro Tafoya",
						ModifiedBy = "Asha Deckow",
						PatientId = 82
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-11-2019"),
						TreatDescription = "Lung volume reduction surgery (procedure)",
						Created = DateTime.Parse("4-27-2019"),
						Modified = DateTime.Parse("8-20-2019"),
						CreatedBy = "Avery Abbott",
						ModifiedBy = "Charity Ebert",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-24-2019"),
						TreatDescription = "Ultrasonography of abdomen  right upper quadrant and epigastrium",
						Created = DateTime.Parse("6-16-2019"),
						Modified = DateTime.Parse("8-17-2019"),
						CreatedBy = "Merle Bradtke",
						ModifiedBy = "Randolph Donnelly",
						PatientId = 37
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-4-2019"),
						TreatDescription = "Knee X-ray",
						Created = DateTime.Parse("12-3-2019"),
						Modified = DateTime.Parse("2-3-2020"),
						CreatedBy = "Mateo Meja­a",
						ModifiedBy = "Petronila Reynolds",
						PatientId = 46
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-13-2019"),
						TreatDescription = "Diagnostic fiberoptic bronchoscopy (procedure)",
						Created = DateTime.Parse("6-10-2019"),
						Modified = DateTime.Parse("9-15-2019"),
						CreatedBy = "Codi Bechtelar",
						ModifiedBy = "Carlota Anaya",
						PatientId = 40
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-18-2019"),
						TreatDescription = "Pelvis X-ray",
						Created = DateTime.Parse("9-11-2019"),
						Modified = DateTime.Parse("11-4-2019"),
						CreatedBy = "Kizzy Larson",
						ModifiedBy = "Darnell Medhurst",
						PatientId = 72
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-5-2020"),
						TreatDescription = "Subcutaneous immunotherapy",
						Created = DateTime.Parse("11-7-2020"),
						Modified = DateTime.Parse("12-19-2020"),
						CreatedBy = "Caroline Konopelski",
						ModifiedBy = "Mechelle Mosciski",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-17-2020"),
						TreatDescription = "Suture open wound",
						Created = DateTime.Parse("4-28-2020"),
						Modified = DateTime.Parse("6-9-2020"),
						CreatedBy = "Noe Moore",
						ModifiedBy = "Evan Bins",
						PatientId = 48
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-25-2019"),
						TreatDescription = "Human immunodeficiency virus antigen test",
						Created = DateTime.Parse("6-19-2019"),
						Modified = DateTime.Parse("8-18-2019"),
						CreatedBy = "Marcellus Armstrong",
						ModifiedBy = "Armando Mondraga³n",
						PatientId = 85
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-4-2019"),
						TreatDescription = "Antenatal RhD antibody screening",
						Created = DateTime.Parse("1-4-2020"),
						Modified = DateTime.Parse("3-10-2020"),
						CreatedBy = "Francisco Funk",
						ModifiedBy = "Eun Ward",
						PatientId = 42
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-28-2020"),
						TreatDescription = "Alpha-fetoprotein test",
						Created = DateTime.Parse("8-23-2020"),
						Modified = DateTime.Parse("10-7-2020"),
						CreatedBy = "Kraig Toy",
						ModifiedBy = "Faustino Lakin",
						PatientId = 67
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-7-2019"),
						TreatDescription = "Plain chest X-ray",
						Created = DateTime.Parse("12-24-2019"),
						Modified = DateTime.Parse("4-20-2020"),
						CreatedBy = "Bernardine Eichmann",
						ModifiedBy = "Silas Waters",
						PatientId = 11
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-14-2020"),
						TreatDescription = "Review of systems (procedure)",
						Created = DateTime.Parse("11-19-2020"),
						Modified = DateTime.Parse("3-2-2021"),
						CreatedBy = "Angelo Cole",
						ModifiedBy = "Benjama­n Longoria",
						PatientId = 38
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-27-2019"),
						TreatDescription = "Nasal sinus endoscopy (procedure)",
						Created = DateTime.Parse("11-11-2019"),
						Modified = DateTime.Parse("1-9-2020"),
						CreatedBy = "Kenton Schultz",
						ModifiedBy = "Felton Schaefer",
						PatientId = 65
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-17-2019"),
						TreatDescription = "Alpha-fetoprotein test",
						Created = DateTime.Parse("12-5-2019"),
						Modified = DateTime.Parse("2-7-2020"),
						CreatedBy = "Sanjuana Heaney",
						ModifiedBy = "Jalisa O'Hara",
						PatientId = 51
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-26-2019"),
						TreatDescription = "Rubella screening",
						Created = DateTime.Parse("3-25-2020"),
						Modified = DateTime.Parse("5-20-2020"),
						CreatedBy = "Rodrigo Larson",
						ModifiedBy = "Buford Reichel",
						PatientId = 44
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-24-2019"),
						TreatDescription = "Pregnancy termination care",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("1-31-2020"),
						CreatedBy = "Irene Rola³n",
						ModifiedBy = "Ranae Luettgen",
						PatientId = 52
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-16-2019"),
						TreatDescription = "Physical examination",
						Created = DateTime.Parse("8-3-2019"),
						Modified = DateTime.Parse("11-9-2019"),
						CreatedBy = "Charise Gottlieb",
						ModifiedBy = "Mathilde Lynch",
						PatientId = 94
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-20-2019"),
						TreatDescription = "Ultrasonography of abdomen  right upper quadrant and epigastrium",
						Created = DateTime.Parse("2-3-2020"),
						Modified = DateTime.Parse("4-1-2020"),
						CreatedBy = "Armanda Ward",
						ModifiedBy = "Graciela Lebra³n",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-30-2020"),
						TreatDescription = "Medical induction of labor",
						Created = DateTime.Parse("11-12-2020"),
						Modified = DateTime.Parse("2-5-2021"),
						CreatedBy = "Alona Kohler",
						ModifiedBy = "Ramon Smith",
						PatientId = 23
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-4-2019"),
						TreatDescription = "Physical exam following abortion",
						Created = DateTime.Parse("9-3-2019"),
						Modified = DateTime.Parse("11-23-2019"),
						CreatedBy = "Jacquelyn Pouros",
						ModifiedBy = "Gabriela Serrano",
						PatientId = 7
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-14-2020"),
						TreatDescription = "Human immunodeficiency virus antigen test",
						Created = DateTime.Parse("1-24-2021"),
						Modified = DateTime.Parse("3-21-2021"),
						CreatedBy = "Lanny Wiza",
						ModifiedBy = "Roxann Borer",
						PatientId = 31
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-11-2019"),
						TreatDescription = "positive screening for PHQ-9",
						Created = DateTime.Parse("8-30-2019"),
						Modified = DateTime.Parse("11-8-2019"),
						CreatedBy = "Marco Abshire",
						ModifiedBy = "Eric Okuneva",
						PatientId = 79
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-8-2019"),
						TreatDescription = "Seizure Count Cerebral Cortex Electroencephalogram (EEG)",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("12-29-2019"),
						CreatedBy = "Sibyl Feest",
						ModifiedBy = "Wonda Lakin",
						PatientId = 55
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-30-2020"),
						TreatDescription = "Cytopathology procedure  preparation of smear  genital source (procedure)",
						Created = DateTime.Parse("10-10-2020"),
						Modified = DateTime.Parse("1-7-2021"),
						CreatedBy = "Tom Wintheiser",
						ModifiedBy = "Jeff Mueller",
						PatientId = 44
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-13-2019"),
						TreatDescription = "Cesarean section",
						Created = DateTime.Parse("7-25-2019"),
						Modified = DateTime.Parse("9-13-2019"),
						CreatedBy = "Doloris Swaniawski",
						ModifiedBy = "Forest Hermiston",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-13-2020"),
						TreatDescription = "Childbirth",
						Created = DateTime.Parse("6-6-2020"),
						Modified = DateTime.Parse("9-15-2020"),
						CreatedBy = "Melissa King",
						ModifiedBy = "Wilburn Kohler",
						PatientId = 20
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-9-2020"),
						TreatDescription = "Ankle X-ray",
						Created = DateTime.Parse("1-17-2021"),
						Modified = DateTime.Parse("4-23-2021"),
						CreatedBy = "Kenia Miller",
						ModifiedBy = "Peter Homenick",
						PatientId = 17
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-29-2020"),
						TreatDescription = "Auscultation of the fetal heart",
						Created = DateTime.Parse("2-9-2021"),
						Modified = DateTime.Parse("5-24-2021"),
						CreatedBy = "Kory Davis",
						ModifiedBy = "Bennett Breitenberg",
						PatientId = 91
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-14-2019"),
						TreatDescription = "Chemotherapy (procedure)",
						Created = DateTime.Parse("4-20-2019"),
						Modified = DateTime.Parse("6-16-2019"),
						CreatedBy = "Stevie Homenick",
						ModifiedBy = "Maricarmen Armenta",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-31-2019"),
						TreatDescription = "Urine screening test for diabetes",
						Created = DateTime.Parse("11-4-2019"),
						Modified = DateTime.Parse("1-3-2020"),
						CreatedBy = "Aliza Feil",
						ModifiedBy = "Aurelio Shanahan",
						PatientId = 38
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-13-2020"),
						TreatDescription = "Transthoracic three dimensional ultrasonography of heart (procedure)",
						Created = DateTime.Parse("3-3-2021"),
						Modified = DateTime.Parse("4-21-2021"),
						CreatedBy = "Teresia Mitchell",
						ModifiedBy = "Michal Stoltenberg",
						PatientId = 27
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-27-2020"),
						TreatDescription = "Referral to hypertension clinic",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("2-24-2021"),
						CreatedBy = "Tammie Padberg",
						ModifiedBy = "Angelique Balistreri",
						PatientId = 83
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-13-2019"),
						TreatDescription = "Admission to burn unit",
						Created = DateTime.Parse("12-7-2019"),
						Modified = DateTime.Parse("2-19-2020"),
						CreatedBy = "Joanna Koelpin",
						ModifiedBy = "Sarai Haag",
						PatientId = 65
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-28-2019"),
						TreatDescription = "Sputum microscopy (procedure)",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("11-17-2019"),
						CreatedBy = "Kiyoko Boehm",
						ModifiedBy = "Darryl O'Conner",
						PatientId = 61
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-13-2020"),
						TreatDescription = "RhD passive immunization",
						Created = DateTime.Parse("10-15-2020"),
						Modified = DateTime.Parse("12-25-2020"),
						CreatedBy = "Isabelle Emmerich",
						ModifiedBy = "Riley Hirthe",
						PatientId = 34
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-15-2020"),
						TreatDescription = "Blood typing  RH typing",
						Created = DateTime.Parse("10-16-2020"),
						Modified = DateTime.Parse("12-20-2020"),
						CreatedBy = "Glenna Spinka",
						ModifiedBy = "Alysha Kerluke",
						PatientId = 15
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-29-2019"),
						TreatDescription = "Asthma screening",
						Created = DateTime.Parse("3-17-2020"),
						Modified = DateTime.Parse("4-16-2020"),
						CreatedBy = "Elvia Abbott",
						ModifiedBy = "Leilani Ruecker",
						PatientId = 79
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-24-2019"),
						TreatDescription = "Plain chest X-ray (procedure)",
						Created = DateTime.Parse("2-8-2020"),
						Modified = DateTime.Parse("5-5-2020"),
						CreatedBy = "Willia Fritsch",
						ModifiedBy = "Ira Prohaska",
						PatientId = 97
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-3-2020"),
						TreatDescription = "Information gathering (procedure)",
						Created = DateTime.Parse("7-16-2020"),
						Modified = DateTime.Parse("10-30-2019"),
						CreatedBy = "Carmon Hackett",
						ModifiedBy = "Ahmed Jast",
						PatientId = 20
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-28-2019"),
						TreatDescription = "Antenatal RhD antibody screening",
						Created = DateTime.Parse("9-29-2020"),
						Modified = DateTime.Parse("5-24-2021"),
						CreatedBy = "Chase Cummings",
						ModifiedBy = "Logan Dietrich",
						PatientId = 34
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-24-2020"),
						TreatDescription = "Knee X-ray",
						Created = DateTime.Parse("5-24-2019"),
						Modified = DateTime.Parse("9-23-2020"),
						CreatedBy = "Travis Turcotte",
						ModifiedBy = "Katherin Borer",
						PatientId = 69
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-7-2020"),
						TreatDescription = "Plain chest X-ray (procedure)",
						Created = DateTime.Parse("1-10-2021"),
						Modified = DateTime.Parse("12-16-2019"),
						CreatedBy = "Dorla Oberbrunner",
						ModifiedBy = "Linnie Beier",
						PatientId = 73
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-14-2019"),
						TreatDescription = "Magnetic resonance imaging of breast (procedure)",
						Created = DateTime.Parse("4-5-2020"),
						Modified = DateTime.Parse("11-9-2020"),
						CreatedBy = "Ok Kirlin",
						ModifiedBy = "Chery Bradtke",
						PatientId = 86
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-16-2020"),
						TreatDescription = "Ultrasonography of bilateral breasts (procedure)",
						Created = DateTime.Parse("10-18-2019"),
						Modified = DateTime.Parse("12-22-2019"),
						CreatedBy = "Selina Miller",
						ModifiedBy = "Seema Purdy",
						PatientId = 4
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-26-2019"),
						TreatDescription = "Excision of breast tissue (procedure)",
						Created = DateTime.Parse("4-15-2020"),
						Modified = DateTime.Parse("7-23-2020"),
						CreatedBy = "Awilda Balistreri",
						ModifiedBy = "Junior Reilly",
						PatientId = 74
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("8-3-2019"),
						TreatDescription = "Measurement of respiratory function (procedure)",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("4-21-2021"),
						CreatedBy = "Theron Schiller",
						ModifiedBy = "Cedrick Abbott",
						PatientId = 53
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-2-2020"),
						TreatDescription = "Ultrasound scan for fetal viability",
						Created = DateTime.Parse("9-15-2020"),
						Modified = DateTime.Parse("11-20-2019"),
						CreatedBy = "Mara­a del Carmen Casares",
						ModifiedBy = "Bernardine Eichmann",
						PatientId = 96
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Surgical manipulation of shoulder joint",
						Created = DateTime.Parse("4-12-2019"),
						Modified = DateTime.Parse("2-27-2021"),
						CreatedBy = "Horace Baumbach",
						ModifiedBy = "Bryce Rice",
						PatientId = 20
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-4-2020"),
						TreatDescription = "Ultrasound scan for fetal viability",
						Created = DateTime.Parse("12-18-2020"),
						Modified = DateTime.Parse("6-29-2019"),
						CreatedBy = "Rodrigo Crespo",
						ModifiedBy = "Lavette West",
						PatientId = 66
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-6-2019"),
						TreatDescription = "Human immunodeficiency virus antigen test",
						Created = DateTime.Parse("2-5-2021"),
						Modified = DateTime.Parse("5-27-2020"),
						CreatedBy = "Francesco Ullrich",
						ModifiedBy = "Charlsie Halvorson",
						PatientId = 36
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-1-2020"),
						TreatDescription = "Physical examination",
						Created = DateTime.Parse("3-9-2020"),
						Modified = DateTime.Parse("2-17-2020"),
						CreatedBy = "Keneth Streich",
						ModifiedBy = "Lenna Zemlak",
						PatientId = 25
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-14-2020"),
						TreatDescription = "Admission to trauma surgery department",
						Created = DateTime.Parse("8-26-2019"),
						Modified = DateTime.Parse("1-25-2021"),
						CreatedBy = "Tequila Kozey",
						ModifiedBy = "Ute Gorczany",
						PatientId = 58
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-3-2020"),
						TreatDescription = "Human epidermal growth factor receptor 2 gene detection by immunohistochemistry (procedure)",
						Created = DateTime.Parse("6-17-2019"),
						Modified = DateTime.Parse("4-19-2020"),
						CreatedBy = "Shirlee Mayert",
						ModifiedBy = "Emerson Stanton",
						PatientId = 94
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-7-2019"),
						TreatDescription = "Bone immobilization",
						Created = DateTime.Parse("1-30-2020"),
						Modified = DateTime.Parse("3-6-2021"),
						CreatedBy = "Alease Dare",
						ModifiedBy = "Alisha Kutch",
						PatientId = 82
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-30-2019"),
						TreatDescription = "Admission to orthopedic department",
						Created = DateTime.Parse("10-20-2020"),
						Modified = DateTime.Parse("5-27-2019"),
						CreatedBy = "Bettie Turcotte",
						ModifiedBy = "Romeo Gerlach",
						PatientId = 51
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-23-2019"),
						TreatDescription = "Lung volume reduction surgery (procedure)",
						Created = DateTime.Parse("5-28-2019"),
						Modified = DateTime.Parse("6-19-2020"),
						CreatedBy = "King Hyatt",
						ModifiedBy = "Francesca Purdy",
						PatientId = 16
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-2-2020"),
						TreatDescription = "Episiotomy",
						Created = DateTime.Parse("9-22-2019"),
						Modified = DateTime.Parse("11-7-2020"),
						CreatedBy = "Elisha Huels",
						ModifiedBy = "Liberty Glover",
						PatientId = 33
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-26-2019"),
						TreatDescription = "Biopsy of colon",
						Created = DateTime.Parse("9-7-2019"),
						Modified = DateTime.Parse("3-20-2020"),
						CreatedBy = "Ryan Morar",
						ModifiedBy = "Tressie Schamberger",
						PatientId = 76
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-12-2019"),
						TreatDescription = "Spirometry (procedure)",
						Created = DateTime.Parse("8-6-2020"),
						Modified = DateTime.Parse("6-16-2019"),
						CreatedBy = "Kay Tremblay",
						ModifiedBy = "Ahmed Jast",
						PatientId = 70
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-30-2019"),
						TreatDescription = "Nasal sinus endoscopy (procedure)",
						Created = DateTime.Parse("4-9-2020"),
						Modified = DateTime.Parse("9-12-2020"),
						CreatedBy = "Mika Roob",
						ModifiedBy = "Arturo Guerra",
						PatientId = 87
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-5-2020"),
						TreatDescription = "Admission to long stay hospital",
						Created = DateTime.Parse("5-21-2020"),
						Modified = DateTime.Parse("11-28-2019"),
						CreatedBy = "Nam MacGyver",
						ModifiedBy = "Margarito Stoltenberg",
						PatientId = 57
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-12-2020"),
						TreatDescription = "Throat culture (procedure)",
						Created = DateTime.Parse("1-3-2020"),
						Modified = DateTime.Parse("10-30-2020"),
						CreatedBy = "Floyd Miller",
						ModifiedBy = "Damon Wintheiser",
						PatientId = 80
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-9-2020"),
						TreatDescription = "Evaluation of uterine fundal height",
						Created = DateTime.Parse("4-8-2021"),
						Modified = DateTime.Parse("12-4-2020"),
						CreatedBy = "Lorena Gutiaerrez",
						ModifiedBy = "Barbie Kuhic",
						PatientId = 4
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-19-2019"),
						TreatDescription = "Childbirth",
						Created = DateTime.Parse("12-26-2020"),
						Modified = DateTime.Parse("4-7-2020"),
						CreatedBy = "Marylou Koch",
						ModifiedBy = "Damon Wintheiser",
						PatientId = 16
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-10-2020"),
						TreatDescription = "Rectal polypectomy",
						Created = DateTime.Parse("6-23-2020"),
						Modified = DateTime.Parse("10-26-2019"),
						CreatedBy = "Sibyl Balistreri",
						ModifiedBy = "Brunilda Hegmann",
						PatientId = 11
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Ultrasonography of bilateral breasts (procedure)",
						Created = DateTime.Parse("3-30-2020"),
						Modified = DateTime.Parse("4-22-2021"),
						CreatedBy = "Bradly Labadie",
						ModifiedBy = "Jonah Kemmer",
						PatientId = 17
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-13-2020"),
						TreatDescription = "Sputum examination (procedure)",
						Created = DateTime.Parse("9-17-2019"),
						Modified = DateTime.Parse("1-12-2020"),
						CreatedBy = "Ezekiel Wyman",
						ModifiedBy = "Cyndy Schowalter",
						PatientId = 31
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-21-2020"),
						TreatDescription = "Ultrasonography of bilateral breasts (procedure)",
						Created = DateTime.Parse("2-24-2021"),
						Modified = DateTime.Parse("8-20-2019"),
						CreatedBy = "Evangelina Sipes",
						ModifiedBy = "Hershel Murazik",
						PatientId = 88
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-21-2019"),
						TreatDescription = "Injection of tetanus antitoxin",
						Created = DateTime.Parse("7-18-2020"),
						Modified = DateTime.Parse("8-17-2019"),
						CreatedBy = "Maricarmen Loya",
						ModifiedBy = "Angila Pfeffer",
						PatientId = 33
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-12-2020"),
						TreatDescription = "Surgical manipulation of shoulder joint",
						Created = DateTime.Parse("10-14-2019"),
						Modified = DateTime.Parse("2-3-2020"),
						CreatedBy = "Elijah Schmitt",
						ModifiedBy = "Kieth Orn",
						PatientId = 90
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("4-16-2020"),
						TreatDescription = "Intravenous blood transfusion of packed cells (procedure)",
						Created = DateTime.Parse("10-3-2020"),
						Modified = DateTime.Parse("9-15-2019"),
						CreatedBy = "Jolyn Bechtelar",
						ModifiedBy = "Cara Ruecker",
						PatientId = 62
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("9-7-2019"),
						TreatDescription = "Epidural anesthesia",
						Created = DateTime.Parse("10-24-2019"),
						Modified = DateTime.Parse("11-4-2019"),
						CreatedBy = "Sammie Harris",
						ModifiedBy = "Malvina Dicki",
						PatientId = 60
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-26-2020"),
						TreatDescription = "Hearing examination (procedure)",
						Created = DateTime.Parse("6-20-2020"),
						Modified = DateTime.Parse("12-19-2020"),
						CreatedBy = "Ben O'Reilly",
						ModifiedBy = "Andra Heidenreich",
						PatientId = 38
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("7-3-2019"),
						TreatDescription = "Peripheral blood smear interpretation",
						Created = DateTime.Parse("3-6-2021"),
						Modified = DateTime.Parse("6-9-2020"),
						CreatedBy = "Carlton Kuhlman",
						ModifiedBy = "Horacio Bednar",
						PatientId = 39
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-7-2020"),
						TreatDescription = "Extraction of wisdom tooth",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("8-18-2019"),
						CreatedBy = "Benjama­n Medina",
						ModifiedBy = "Yolanda Rivero",
						PatientId = 5
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-8-2020"),
						TreatDescription = "Epidural anesthesia",
						Created = DateTime.Parse("11-17-2020"),
						Modified = DateTime.Parse("3-10-2020"),
						CreatedBy = "Maryland Yundt",
						ModifiedBy = "Orville Marks",
						PatientId = 49
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("5-9-2019"),
						TreatDescription = "Intramuscular injection",
						Created = DateTime.Parse("4-30-2019"),
						Modified = DateTime.Parse("10-7-2020"),
						CreatedBy = "Kimberlie D'Amore",
						ModifiedBy = "Rhett Barrows",
						PatientId = 77
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-13-2020"),
						TreatDescription = "Depression screening using Patient Health Questionnaire Nine Item score (procedure)",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("4-20-2020"),
						CreatedBy = "Carolyn Murray",
						ModifiedBy = "Buffy Price",
						PatientId = 7
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("3-18-2019"),
						TreatDescription = "Urine culture",
						Created = DateTime.Parse("12-13-2019"),
						Modified = DateTime.Parse("3-2-2021"),
						CreatedBy = "Jackelyn Gulgowski",
						ModifiedBy = "Patti Douglas",
						PatientId = 75
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-17-2019"),
						TreatDescription = "Magnetic resonance imaging of breast (procedure)",
						Created = DateTime.Parse("10-2-2020"),
						Modified = DateTime.Parse("1-9-2020"),
						CreatedBy = "Kaylene Waters",
						ModifiedBy = "Donnetta McGlynn",
						PatientId = 85
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-24-2019"),
						TreatDescription = "Spontaneous breech delivery",
						Created = DateTime.Parse("3-4-2020"),
						Modified = DateTime.Parse("2-7-2020"),
						CreatedBy = "Eloy Rath",
						ModifiedBy = "Jeromy Grant",
						PatientId = 59
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-17-2020"),
						TreatDescription = "Construction of diverting colostomy",
						Created = DateTime.Parse("1-19-2021"),
						Modified = DateTime.Parse("5-20-2020"),
						CreatedBy = "Mateo Meja­a",
						ModifiedBy = "Jeff Wolf",
						PatientId = 96
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("12-10-2019"),
						TreatDescription = "Pulmonary rehabilitation (regime/therapy)",
						Created = DateTime.Parse("4-18-2019"),
						Modified = DateTime.Parse("1-31-2020"),
						CreatedBy = "Salvador Boyer",
						ModifiedBy = "Adrianne Bartell",
						PatientId = 25
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("11-17-2020"),
						TreatDescription = "Partial resection of colon",
						Created = DateTime.Parse("4-19-2020"),
						Modified = DateTime.Parse("11-9-2019"),
						CreatedBy = "Judy Wintheiser",
						ModifiedBy = "Lorena Gutiaerrez",
						PatientId = 80
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("1-17-2019"),
						TreatDescription = "Vasectomy",
						Created = DateTime.Parse("10-4-2020"),
						Modified = DateTime.Parse("4-1-2020"),
						CreatedBy = "Amado Schamberger",
						ModifiedBy = "Christene Balistreri",
						PatientId = 28
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("2-14-2020"),
						TreatDescription = "Computed tomography of chest and abdomen",
						Created = DateTime.Parse("12-23-2019"),
						Modified = DateTime.Parse("2-5-2021"),
						CreatedBy = "Jesse Stracke",
						ModifiedBy = "Dane Russel",
						PatientId = 29
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("6-16-2020"),
						TreatDescription = "Hepatitis B Surface Antigen Measurement",
						Created = DateTime.Parse("4-24-2019"),
						Modified = DateTime.Parse("11-23-2019"),
						CreatedBy = "Shera Konopelski",
						ModifiedBy = "Yanira Mills",
						PatientId = 9
					},
				new Treatment
					{
						TreatmentDate = DateTime.Parse("10-30-2019"),
						TreatDescription = "Removal of intrauterine device",
						Created = DateTime.Parse("7-13-2020"),
						Modified = DateTime.Parse("3-21-2021"),
						CreatedBy = "Lupe Herzog",
						ModifiedBy = "Anja Luettgen",
						PatientId = 48
					}

			};

			treatments.ForEach(t => context.Treatments.AddOrUpdate(t));
			context.SaveChanges();

			if (context.Medications.Any())
				{
				return;
				}

			var medications = new List<Medication>
				{
								new Medication
					{
						MedicationDate = DateTime.Parse("3-17-2019"),
						MedicationName = "Ortho Tri-Cyclen 28 Day Pack",
						Created = DateTime.Parse("5-10-2019"),
						Modified = DateTime.Parse("8-29-2019"),
						CreatedBy = "Todd Blanda",
						ModifiedBy = "Elvira Ba�ez",
						PatientId = 9
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-22-2020"),
						MedicationName = "Nitroglycerin 0.4 MG/ACTUAT Mucosal Spray",
						Created = DateTime.Parse("9-19-2020"),
						Modified = DateTime.Parse("12-10-2020"),
						CreatedBy = "Jacquelynn Crooks",
						ModifiedBy = "Kymberly Nolan",
						PatientId = 29
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-14-2019"),
						MedicationName = "Milnacipran hydrochloride 100 MG [Savella]",
						Created = DateTime.Parse("3-23-2019"),
						Modified = DateTime.Parse("7-4-2019"),
						CreatedBy = "Margarite Bruen",
						ModifiedBy = "Nathan Emmerich",
						PatientId = 100
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-1-2020"),
						MedicationName = "Levothyroxine Sodium 0.075 MG Oral Tablet",
						Created = DateTime.Parse("10-28-2019"),
						Modified = DateTime.Parse("1-8-2020"),
						CreatedBy = "Myong Mueller",
						ModifiedBy = "Loyd McGlynn",
						PatientId = 20
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-8-2019"),
						MedicationName = "60 ACTUAT Fluticasone propionate 0.25 MG/ACTUAT / salmeterol 0.05 MG/ACTUAT Dry Powder Inhaler",
						Created = DateTime.Parse("8-14-2019"),
						Modified = DateTime.Parse("10-6-2019"),
						CreatedBy = "Katherin Dicki",
						ModifiedBy = "Marion Ledner",
						PatientId = 61
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-16-2020"),
						MedicationName = "Galantamine 4 MG Oral Tablet",
						Created = DateTime.Parse("10-11-2020"),
						Modified = DateTime.Parse("1-7-2021"),
						CreatedBy = "Lindsy Boehm",
						ModifiedBy = "Michel Moore",
						PatientId = 36
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-19-2020"),
						MedicationName = "Loratadine 10 MG Oral Tablet",
						Created = DateTime.Parse("1-13-2021"),
						Modified = DateTime.Parse("2-21-2021"),
						CreatedBy = "Booker Jast",
						ModifiedBy = "Temple Reinger",
						PatientId = 49
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-14-2020"),
						MedicationName = "Doxycycline Monohydrate 100 MG Oral Tablet",
						Created = DateTime.Parse("5-17-2020"),
						Modified = DateTime.Parse("8-14-2020"),
						CreatedBy = "Freddie Lowe",
						ModifiedBy = "Raphael Pagac",
						PatientId = 43
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-27-2020"),
						MedicationName = "Aspirin 81 MG Oral Tablet",
						Created = DateTime.Parse("1-18-2021"),
						Modified = DateTime.Parse("4-1-2021"),
						CreatedBy = "Elliott Stamm",
						ModifiedBy = "Emily Bauch",
						PatientId = 41
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-30-2020"),
						MedicationName = "2 ML Ondansetron 2 MG/ML Injection",
						Created = DateTime.Parse("1-23-2021"),
						Modified = DateTime.Parse("3-11-2021"),
						CreatedBy = "Annetta Ondricka",
						ModifiedBy = "Porfirio Rippin",
						PatientId = 46
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-23-2020"),
						MedicationName = "Chlorpheniramine Maleate 4 MG Oral Tablet",
						Created = DateTime.Parse("11-4-2020"),
						Modified = DateTime.Parse("12-14-2020"),
						CreatedBy = "Lyda Bartoletti",
						ModifiedBy = "Marinda Kunze",
						PatientId = 37
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-10-2020"),
						MedicationName = "exemestane 25 MG Oral Tablet",
						Created = DateTime.Parse("5-20-2020"),
						Modified = DateTime.Parse("7-14-2020"),
						CreatedBy = "Maybell Langworth",
						ModifiedBy = "Ivonne Rowe",
						PatientId = 82
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-5-2020"),
						MedicationName = "Rocuronium bromide 10 MG/ML Injectable Solution",
						Created = DateTime.Parse("12-20-2020"),
						Modified = DateTime.Parse("3-10-2021"),
						CreatedBy = "Manuel Eichmann",
						ModifiedBy = "Armando Razo",
						PatientId = 20
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-25-2019"),
						MedicationName = "200 ACTUAT Albuterol 0.09 MG/ACTUAT Metered Dose Inhaler",
						Created = DateTime.Parse("2-10-2020"),
						Modified = DateTime.Parse("3-16-2020"),
						CreatedBy = "An Bartoletti",
						ModifiedBy = "Akilah Kassulke",
						PatientId = 7
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-8-2019"),
						MedicationName = "diphenhydrAMINE Hydrochloride 25 MG Oral Tablet",
						Created = DateTime.Parse("2-27-2020"),
						Modified = DateTime.Parse("6-24-2020"),
						CreatedBy = "Ladonna O'Hara",
						ModifiedBy = "Will Murphy",
						PatientId = 25
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-26-2020"),
						MedicationName = "Acetaminophen 325 MG / HYDROcodone Bitartrate 7.5 MG Oral Tablet",
						Created = DateTime.Parse("1-17-2021"),
						Modified = DateTime.Parse("5-7-2021"),
						CreatedBy = "Rubie Braun",
						ModifiedBy = "Felipe Nava",
						PatientId = 79
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-5-2020"),
						MedicationName = "1 ML Epoetin Alfa 4000 UNT/ML Injection [Epogen]",
						Created = DateTime.Parse("9-5-2020"),
						Modified = DateTime.Parse("10-18-2020"),
						CreatedBy = "Beverlee Kassulke",
						ModifiedBy = "Rico Homenick",
						PatientId = 39
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-29-2020"),
						MedicationName = "Errin 28 Day Pack",
						Created = DateTime.Parse("8-5-2020"),
						Modified = DateTime.Parse("10-3-2020"),
						CreatedBy = "Royce Brown",
						ModifiedBy = "Kandace Mann",
						PatientId = 6
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-29-2020"),
						MedicationName = "Simvastatin 20 MG Oral Tablet",
						Created = DateTime.Parse("8-26-2020"),
						Modified = DateTime.Parse("10-26-2020"),
						CreatedBy = "Heriberto Hagenes",
						ModifiedBy = "Deb Collins",
						PatientId = 17
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-14-2019"),
						MedicationName = "Digoxin 0.125 MG Oral Tablet",
						Created = DateTime.Parse("12-26-2019"),
						Modified = DateTime.Parse("4-2-2020"),
						CreatedBy = "Genevie Rowe",
						ModifiedBy = "Daniel Zieme",
						PatientId = 57
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-31-2020"),
						MedicationName = "heparin sodium  porcine",
						Created = DateTime.Parse("11-23-2020"),
						Modified = DateTime.Parse("3-21-2021"),
						CreatedBy = "Clair Walter",
						ModifiedBy = "Lenore Romaguera",
						PatientId = 43
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-13-2020"),
						MedicationName = "Cefuroxime 250 MG Oral Tablet",
						Created = DateTime.Parse("9-17-2020"),
						Modified = DateTime.Parse("1-1-2021"),
						CreatedBy = "Rocco Schamberger",
						ModifiedBy = "Dario Torp",
						PatientId = 67
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-1-2019"),
						MedicationName = "Hydrochlorothiazide 12.5 MG",
						Created = DateTime.Parse("11-6-2019"),
						Modified = DateTime.Parse("1-16-2020"),
						CreatedBy = "Alfredo Kuhic",
						ModifiedBy = "Maria Reynolds",
						PatientId = 57
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-4-2019"),
						MedicationName = "Amlodipine 5 MG / Hydrochlorothiazide 12.5 MG / Olmesartan medoxomil 20 MG",
						Created = DateTime.Parse("1-1-2020"),
						Modified = DateTime.Parse("3-19-2020"),
						CreatedBy = "Carina Connelly",
						ModifiedBy = "Rafael Gonzales",
						PatientId = 62
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-16-2019"),
						MedicationName = "10 ML Furosemide 10 MG/ML Injection",
						Created = DateTime.Parse("12-2-2019"),
						Modified = DateTime.Parse("3-29-2020"),
						CreatedBy = "Daphne Hyatt",
						ModifiedBy = "Gus Okuneva",
						PatientId = 80
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-6-2020"),
						MedicationName = "24 HR Donepezil hydrochloride 10 MG / Memantine hydrochloride 28 MG Extended Release Oral Capsule",
						Created = DateTime.Parse("12-9-2020"),
						Modified = DateTime.Parse("3-25-2021"),
						CreatedBy = "Genaro Lubowitz",
						ModifiedBy = "Milan Rolfson",
						PatientId = 46
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-23-2020"),
						MedicationName = "Fentanyl",
						Created = DateTime.Parse("5-5-2020"),
						Modified = DateTime.Parse("8-29-2020"),
						CreatedBy = "Odessa Rolfson",
						ModifiedBy = "Lorena Gutiaerrez",
						PatientId = 23
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-1-2019"),
						MedicationName = "Levothyroxine Sodium 0.075 MG Oral Tablet",
						Created = DateTime.Parse("10-12-2019"),
						Modified = DateTime.Parse("1-11-2020"),
						CreatedBy = "Florida Price",
						ModifiedBy = "Lacie Yost",
						PatientId = 67
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-17-2020"),
						MedicationName = "anastrozole 1 MG Oral Tablet",
						Created = DateTime.Parse("12-2-2020"),
						Modified = DateTime.Parse("3-11-2021"),
						CreatedBy = "Jules Becker",
						ModifiedBy = "Ellamae Cole",
						PatientId = 9
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-29-2019"),
						MedicationName = "ferrous sulfate 325 MG Oral Tablet",
						Created = DateTime.Parse("3-13-2020"),
						Modified = DateTime.Parse("6-16-2020"),
						CreatedBy = "Richelle Greenholt",
						ModifiedBy = "Logan Farrell",
						PatientId = 32
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-30-2020"),
						MedicationName = "168 HR Ethinyl Estradiol 0.00146 MG/HR / norelgestromin 0.00625 MG/HR Transdermal System",
						Created = DateTime.Parse("10-29-2020"),
						Modified = DateTime.Parse("1-30-2021"),
						CreatedBy = "Victorina Braun",
						ModifiedBy = "Lawerence Lemke",
						PatientId = 89
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-8-2019"),
						MedicationName = "Warfarin Sodium 5 MG Oral Tablet",
						Created = DateTime.Parse("12-6-2019"),
						Modified = DateTime.Parse("2-5-2020"),
						CreatedBy = "Eldon Lesch",
						ModifiedBy = "Nickolas O'Reilly",
						PatientId = 82
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-30-2020"),
						MedicationName = "Midazolam 1 MG/ML Injectable Solution",
						Created = DateTime.Parse("8-28-2020"),
						Modified = DateTime.Parse("10-9-2020"),
						CreatedBy = "Edgar Aufderhar",
						ModifiedBy = "Dana Goldner",
						PatientId = 34
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-18-2019"),
						MedicationName = "Terfenadine 60 MG Oral Tablet",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("12-12-2019"),
						CreatedBy = "Kasey Tromp",
						ModifiedBy = "Junior Herzog",
						PatientId = 24
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-14-2020"),
						MedicationName = "Paclitaxel 100 MG Injection",
						Created = DateTime.Parse("7-19-2020"),
						Modified = DateTime.Parse("10-22-2020"),
						CreatedBy = "Desirae Pollich",
						ModifiedBy = "Mayte Va�zquez",
						PatientId = 27
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-14-2020"),
						MedicationName = "Fexofenadine hydrochloride 60 MG Oral Tablet",
						Created = DateTime.Parse("7-24-2020"),
						Modified = DateTime.Parse("10-24-2020"),
						CreatedBy = "Stephania Champlin",
						ModifiedBy = "Treasa Gislason",
						PatientId = 61
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-26-2019"),
						MedicationName = "Etoposide 100 MG Injection",
						Created = DateTime.Parse("10-5-2019"),
						Modified = DateTime.Parse("1-26-2020"),
						CreatedBy = "Aliza Feil",
						ModifiedBy = "Mikel Crona",
						PatientId = 75
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-20-2019"),
						MedicationName = "cetirizine hydrochloride 5 MG Oral Tablet",
						Created = DateTime.Parse("4-24-2019"),
						Modified = DateTime.Parse("5-27-2019"),
						CreatedBy = "Beatriz Ortega",
						ModifiedBy = "Frieda Swift",
						PatientId = 38
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-3-2019"),
						MedicationName = "Etoposide 100 MG Injection",
						Created = DateTime.Parse("2-11-2019"),
						Modified = DateTime.Parse("4-16-2019"),
						CreatedBy = "Frieda Swift",
						ModifiedBy = "Fidel Runolfsdottir",
						PatientId = 58
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-6-2019"),
						MedicationName = "cetirizine hydrochloride 10 MG Oral Tablet",
						Created = DateTime.Parse("9-5-2019"),
						Modified = DateTime.Parse("12-19-2019"),
						CreatedBy = "Lauralee Wolf",
						ModifiedBy = "Arcelia Okuneva",
						PatientId = 72
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-27-2020"),
						MedicationName = "Meperidine Hydrochloride 50 MG Oral Tablet",
						Created = DateTime.Parse("11-17-2020"),
						Modified = DateTime.Parse("3-2-2021"),
						CreatedBy = "Malinda Bosco",
						ModifiedBy = "Bernardine Erdman",
						PatientId = 21
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-15-2019"),
						MedicationName = "Remifentanil",
						Created = DateTime.Parse("11-26-2019"),
						Modified = DateTime.Parse("1-26-2020"),
						CreatedBy = "Adolph Okuneva",
						ModifiedBy = "Jacqualine Jacobi",
						PatientId = 76
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-7-2020"),
						MedicationName = "Nitrofurantoin 5 MG/ML Oral Suspension",
						Created = DateTime.Parse("3-6-2021"),
						Modified = DateTime.Parse("5-3-2021"),
						CreatedBy = "Deana Schamberger",
						ModifiedBy = "Bok Mosciski",
						PatientId = 62
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-5-2019"),
						MedicationName = "Fluoxetine 25MG",
						Created = DateTime.Parse("9-14-2019"),
						Modified = DateTime.Parse("12-6-2019"),
						CreatedBy = "Hortensia Bogan",
						ModifiedBy = "Catrice Gislason",
						PatientId = 48
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-18-2019"),
						MedicationName = "Acetaminophen 21.7 MG/ML / Dextromethorphan Hydrobromide 1 MG/ML / doxylamine succinate 0.417 MG/ML Oral Solution",
						Created = DateTime.Parse("9-18-2019"),
						Modified = DateTime.Parse("1-6-2020"),
						CreatedBy = "Leopoldo Bashirian",
						ModifiedBy = "Jonah Boyle",
						PatientId = 37
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-24-2019"),
						MedicationName = "100 ML Epirubicin Hydrochloride 2 MG/ML Injection",
						Created = DateTime.Parse("3-11-2020"),
						Modified = DateTime.Parse("4-20-2020"),
						CreatedBy = "Sonny Gerhold",
						ModifiedBy = "Kymberly Nolan",
						PatientId = 62
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-7-2019"),
						MedicationName = "Mirena 52 MG Intrauterine System",
						Created = DateTime.Parse("6-1-2019"),
						Modified = DateTime.Parse("9-8-2019"),
						CreatedBy = "Bula Schowalter",
						ModifiedBy = "Cruz Jenkins",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-16-2020"),
						MedicationName = "Amlodipine 5 MG / Hydrochlorothiazide 12.5 MG / Olmesartan medoxomil 20 MG",
						Created = DateTime.Parse("5-9-2020"),
						Modified = DateTime.Parse("6-23-2020"),
						CreatedBy = "Tonette Gislason",
						ModifiedBy = "Clay Johns",
						PatientId = 53
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-17-2020"),
						MedicationName = "Amlodipine 5 MG / Hydrochlorothiazide 12.5 MG / Olmesartan medoxomil 20 MG",
						Created = DateTime.Parse("3-16-2021"),
						Modified = DateTime.Parse("5-4-2021"),
						CreatedBy = "Margarett Legros",
						ModifiedBy = "Jacquie Beahan",
						PatientId = 93
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-26-2020"),
						MedicationName = "pregabalin 100 MG Oral Capsule",
						Created = DateTime.Parse("2-21-2021"),
						Modified = DateTime.Parse("4-5-2021"),
						CreatedBy = "Nicky Vandervort",
						ModifiedBy = "Eli Toy",
						PatientId = 96
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-31-2020"),
						MedicationName = "predniSONE 5 MG Oral Tablet",
						Created = DateTime.Parse("10-11-2020"),
						Modified = DateTime.Parse("1-27-2021"),
						CreatedBy = "Agripina Berge",
						ModifiedBy = "Stephany Sanford",
						PatientId = 90
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-15-2020"),
						MedicationName = "Doxycycline Monohydrate 100 MG Oral Tablet",
						Created = DateTime.Parse("10-6-2020"),
						Modified = DateTime.Parse("1-2-2021"),
						CreatedBy = "Jeromy Grant",
						ModifiedBy = "Mara�a Eugenia Alaniz",
						PatientId = 5
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-6-2020"),
						MedicationName = "heparin sodium  porcine",
						Created = DateTime.Parse("8-9-2020"),
						Modified = DateTime.Parse("11-6-2020"),
						CreatedBy = "Sheryll Smitham",
						ModifiedBy = "Elliott Stamm",
						PatientId = 90
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-30-2020"),
						MedicationName = "Aspirin 81 MG Oral Tablet",
						Created = DateTime.Parse("4-25-2020"),
						Modified = DateTime.Parse("8-10-2020"),
						CreatedBy = "Hildred Sauer",
						ModifiedBy = "Julian Kris",
						PatientId = 19
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-20-2020"),
						MedicationName = "2 ML Ondansetron 2 MG/ML Injection",
						Created = DateTime.Parse("3-13-2020"),
						Modified = DateTime.Parse("6-15-2020"),
						CreatedBy = "Herna�n Barrientos",
						ModifiedBy = "Tyrell Lebsack",
						PatientId = 53
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-21-2020"),
						MedicationName = "Aspirin 81 MG Oral Tablet",
						Created = DateTime.Parse("6-25-2020"),
						Modified = DateTime.Parse("10-12-2020"),
						CreatedBy = "Brandie Wehner",
						ModifiedBy = "Waylon Pacocha",
						PatientId = 61
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-23-2020"),
						MedicationName = "Methotrexate 10 MG Oral Tablet",
						Created = DateTime.Parse("7-8-2020"),
						Modified = DateTime.Parse("8-25-2020"),
						CreatedBy = "Everett Gottlieb",
						ModifiedBy = "Wayne Kessler",
						PatientId = 27
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-28-2019"),
						MedicationName = "Lorazepam 2 MG/ML Injectable Solution",
						Created = DateTime.Parse("4-12-2019"),
						Modified = DateTime.Parse("7-31-2019"),
						CreatedBy = "Laure Heathcote",
						ModifiedBy = "Deana Ortiz",
						PatientId = 42
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-22-2019"),
						MedicationName = "Loratadine 10 MG Oral Tablet",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("12-30-2019"),
						CreatedBy = "Genevieve Cummerata",
						ModifiedBy = "Donnetta McGlynn",
						PatientId = 54
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-10-2019"),
						MedicationName = "Clopidogrel 75 MG Oral Tablet",
						Created = DateTime.Parse("5-7-2019"),
						Modified = DateTime.Parse("8-3-2019"),
						CreatedBy = "Maricarmen Venegas",
						ModifiedBy = "Leslie Abshire",
						PatientId = 62
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-7-2020"),
						MedicationName = "Vitamin B 12 5 MG/ML Injectable Solution",
						Created = DateTime.Parse("3-10-2020"),
						Modified = DateTime.Parse("5-17-2020"),
						CreatedBy = "Norris Gibson",
						ModifiedBy = "Elsy Corwin",
						PatientId = 86
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-25-2020"),
						MedicationName = "Lasix 40mg",
						Created = DateTime.Parse("3-9-2021"),
						Modified = DateTime.Parse("6-4-2021"),
						CreatedBy = "Gary O'Keefe",
						ModifiedBy = "Tracey Hammes",
						PatientId = 24
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-2-2020"),
						MedicationName = "desflurane 990 MG/ML Inhalant Solution",
						Created = DateTime.Parse("9-21-2020"),
						Modified = DateTime.Parse("11-18-2020"),
						CreatedBy = "Lowell Ziemann",
						ModifiedBy = "Olin Zulauf",
						PatientId = 82
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-12-2019"),
						MedicationName = "Donepezil hydrochloride 10 MG Oral Tablet",
						Created = DateTime.Parse("10-14-2019"),
						Modified = DateTime.Parse("1-16-2020"),
						CreatedBy = "Emma Hettinger",
						ModifiedBy = "Elliott Zieme",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-13-2020"),
						MedicationName = "Seasonique 91 Day Pack",
						Created = DateTime.Parse("2-6-2021"),
						Modified = DateTime.Parse("5-27-2021"),
						CreatedBy = "Morris Dicki",
						ModifiedBy = "Song Simonis",
						PatientId = 76
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-29-2020"),
						MedicationName = "Atenolol 50 MG / Chlorthalidone 25 MG Oral Tablet",
						Created = DateTime.Parse("8-9-2020"),
						Modified = DateTime.Parse("11-2-2020"),
						CreatedBy = "Rosario Skiles",
						ModifiedBy = "Virginia Manzanares",
						PatientId = 48
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-11-2020"),
						MedicationName = "NITROFURANTOIN  MACROCRYSTALS 50 MG Oral Capsule",
						Created = DateTime.Parse("7-19-2020"),
						Modified = DateTime.Parse("8-27-2020"),
						CreatedBy = "Hans Stracke",
						ModifiedBy = "Gregg Nicolas",
						PatientId = 80
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-29-2020"),
						MedicationName = "Hydrocortisone 10 MG/ML Topical Cream",
						Created = DateTime.Parse("1-24-2021"),
						Modified = DateTime.Parse("3-17-2021"),
						CreatedBy = "Reginald Sawayn",
						ModifiedBy = "Charlsie Halvorson",
						PatientId = 33
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-10-2019"),
						MedicationName = "Penicillin G 375 MG/ML Injectable Solution",
						Created = DateTime.Parse("6-21-2019"),
						Modified = DateTime.Parse("9-6-2019"),
						CreatedBy = "Ignacia Little",
						ModifiedBy = "Tracey Vandervort",
						PatientId = 43
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-21-2019"),
						MedicationName = "predniSONE 5 MG Oral Tablet",
						Created = DateTime.Parse("11-3-2019"),
						Modified = DateTime.Parse("12-3-2019"),
						CreatedBy = "Armand Little",
						ModifiedBy = "Carlos Alanis",
						PatientId = 76
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-20-2020"),
						MedicationName = "Astemizole 10 MG Oral Tablet",
						Created = DateTime.Parse("1-26-2021"),
						Modified = DateTime.Parse("4-24-2021"),
						CreatedBy = "Sanford Tremblay",
						ModifiedBy = "Elvin Adams",
						PatientId = 10
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-10-2020"),
						MedicationName = "Hydrocortisone 10 MG/ML Topical Cream",
						Created = DateTime.Parse("6-23-2020"),
						Modified = DateTime.Parse("9-10-2020"),
						CreatedBy = "Esteban Aparicio",
						ModifiedBy = "Jeremy Green",
						PatientId = 36
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-19-2019"),
						MedicationName = "atomoxetine 100 MG Oral Capsule",
						Created = DateTime.Parse("6-13-2019"),
						Modified = DateTime.Parse("8-8-2019"),
						CreatedBy = "Garrett Lakin",
						ModifiedBy = "Wilburn Kohler",
						PatientId = 9
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-7-2019"),
						MedicationName = "Simvistatin 10 MG",
						Created = DateTime.Parse("10-7-2019"),
						Modified = DateTime.Parse("11-17-2019"),
						CreatedBy = "Frances Anderson",
						ModifiedBy = "Lupe Herzog",
						PatientId = 63
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-8-2020"),
						MedicationName = "Amoxicillin 500 MG Oral Tablet",
						Created = DateTime.Parse("2-17-2020"),
						Modified = DateTime.Parse("4-1-2020"),
						CreatedBy = "Jerlene Parker",
						ModifiedBy = "Mara�a Holgua�n",
						PatientId = 71
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-5-2019"),
						MedicationName = "24 HR Metformin hydrochloride 500 MG Extended Release Oral Tablet",
						Created = DateTime.Parse("8-8-2019"),
						Modified = DateTime.Parse("11-15-2019"),
						CreatedBy = "Noelia Muller",
						ModifiedBy = "Augustine Borer",
						PatientId = 24
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-28-2020"),
						MedicationName = "Levonorgestrel 0.00354 MG/HR Drug Implant",
						Created = DateTime.Parse("7-10-2020"),
						Modified = DateTime.Parse("10-5-2020"),
						CreatedBy = "Rafael Sedillo",
						ModifiedBy = "Eusebio Mraz",
						PatientId = 44
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-20-2019"),
						MedicationName = "Fexofenadine hydrochloride 30 MG Oral Tablet",
						Created = DateTime.Parse("12-21-2019"),
						Modified = DateTime.Parse("3-1-2020"),
						CreatedBy = "Keely Emmerich",
						ModifiedBy = "Leslie Douglas",
						PatientId = 29
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-1-2019"),
						MedicationName = "60 ACTUAT Fluticasone propionate 0.25 MG/ACTUAT / salmeterol 0.05 MG/ACTUAT Dry Powder Inhaler",
						Created = DateTime.Parse("9-18-2019"),
						Modified = DateTime.Parse("12-5-2019"),
						CreatedBy = "Molly Leuschke",
						ModifiedBy = "Jesenia Legros",
						PatientId = 63
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-13-2020"),
						MedicationName = "1 ML Morphine Sulfate 5 MG/ML Injection",
						Created = DateTime.Parse("2-24-2021"),
						Modified = DateTime.Parse("4-8-2021"),
						CreatedBy = "Amos Towne",
						ModifiedBy = "Calvin Herzog",
						PatientId = 58
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-1-2020"),
						MedicationName = "Remifentanil",
						Created = DateTime.Parse("3-5-2020"),
						Modified = DateTime.Parse("5-21-2020"),
						CreatedBy = "Javier VonRueden",
						ModifiedBy = "Jacquelyn Lynch",
						PatientId = 52
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-30-2019"),
						MedicationName = "168 HR Ethinyl Estradiol 0.00146 MG/HR / norelgestromin 0.00625 MG/HR Transdermal System",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("3-29-2020"),
						CreatedBy = "Elena Gislason",
						ModifiedBy = "Diego Weber",
						PatientId = 67
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-13-2020"),
						MedicationName = "Rocuronium bromide 10 MG/ML Injectable Solution",
						Created = DateTime.Parse("11-2-2020"),
						Modified = DateTime.Parse("2-10-2021"),
						CreatedBy = "Leandro Terry",
						ModifiedBy = "Jacobo Guzma�n",
						PatientId = 92
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-6-2020"),
						MedicationName = "Fexofenadine hydrochloride 30 MG Oral Tablet",
						Created = DateTime.Parse("5-6-2020"),
						Modified = DateTime.Parse("6-11-2020"),
						CreatedBy = "Johnetta Von",
						ModifiedBy = "Jule Tremblay",
						PatientId = 97
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-16-2019"),
						MedicationName = "Acetaminophen 325 MG / Oxycodone Hydrochloride 5 MG Oral Tablet",
						Created = DateTime.Parse("10-13-2019"),
						Modified = DateTime.Parse("1-4-2020"),
						CreatedBy = "Maryetta Nienow",
						ModifiedBy = "Tomeka Feest",
						PatientId = 86
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-9-2019"),
						MedicationName = "Tamoxifen 10 MG Oral Tablet",
						Created = DateTime.Parse("3-16-2019"),
						Modified = DateTime.Parse("5-3-2019"),
						CreatedBy = "Laure Heathcote",
						ModifiedBy = "Tula O'Conner",
						PatientId = 29
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-28-2020"),
						MedicationName = "10 ML Furosemide 10 MG/ML Injection",
						Created = DateTime.Parse("3-4-2021"),
						Modified = DateTime.Parse("6-7-2021"),
						CreatedBy = "a�scar Griego",
						ModifiedBy = "Salvador Stracke",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-7-2019"),
						MedicationName = "Piperacillin 4000 MG / tazobactam 500 MG Injection",
						Created = DateTime.Parse("2-6-2020"),
						Modified = DateTime.Parse("3-26-2020"),
						CreatedBy = "Jettie Schimmel",
						ModifiedBy = "Luna Effertz",
						PatientId = 31
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-22-2019"),
						MedicationName = "Levora 0.15/30 28 Day Pack",
						Created = DateTime.Parse("1-8-2020"),
						Modified = DateTime.Parse("4-9-2020"),
						CreatedBy = "Suellen Von",
						ModifiedBy = "Josefina Marroqua�n",
						PatientId = 36
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-29-2019"),
						MedicationName = "Naproxen 500 MG Oral Tablet",
						Created = DateTime.Parse("11-16-2019"),
						Modified = DateTime.Parse("2-17-2020"),
						CreatedBy = "Manual Krajcik",
						ModifiedBy = "Treva Littel",
						PatientId = 18
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-24-2019"),
						MedicationName = "Yaz 28 Day Pack",
						Created = DateTime.Parse("6-17-2019"),
						Modified = DateTime.Parse("8-31-2019"),
						CreatedBy = "Jules Becker",
						ModifiedBy = "Stuart Schuppe",
						PatientId = 99
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-15-2019"),
						MedicationName = "Ibuprofen 100 MG Oral Tablet",
						Created = DateTime.Parse("11-24-2019"),
						Modified = DateTime.Parse("3-7-2020"),
						CreatedBy = "Jenae Ondricka",
						ModifiedBy = "Therese Bahringer",
						PatientId = 55
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-3-2019"),
						MedicationName = "Natazia 28 Day Pack",
						Created = DateTime.Parse("3-9-2019"),
						Modified = DateTime.Parse("4-23-2019"),
						CreatedBy = "Rodrigo Noriega",
						ModifiedBy = "Luciano Gutkowski",
						PatientId = 33
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-6-2020"),
						MedicationName = "Errin 28 Day Pack",
						Created = DateTime.Parse("9-23-2020"),
						Modified = DateTime.Parse("1-4-2021"),
						CreatedBy = "Lester Gleason",
						ModifiedBy = "Amos Towne",
						PatientId = 83
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-12-2019"),
						MedicationName = "Terfenadine 60 MG Oral Tablet",
						Created = DateTime.Parse("7-5-2019"),
						Modified = DateTime.Parse("10-28-2019"),
						CreatedBy = "Rudy Simonis",
						ModifiedBy = "Ivana Berge",
						PatientId = 13
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-7-2020"),
						MedicationName = "Diazepam [Valium]",
						Created = DateTime.Parse("7-22-2020"),
						Modified = DateTime.Parse("10-24-2020"),
						CreatedBy = "Ronni Bogan",
						ModifiedBy = "Alona Kohler",
						PatientId = 15
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-25-2020"),
						MedicationName = "Penicillin V Potassium 500 MG Oral Tablet",
						Created = DateTime.Parse("10-19-2020"),
						Modified = DateTime.Parse("1-19-2021"),
						CreatedBy = "Ellamae Medhurst",
						ModifiedBy = "Arla Wilkinson",
						PatientId = 54
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-13-2019"),
						MedicationName = "Captopril 25 MG Oral Tablet",
						Created = DateTime.Parse("7-17-2019"),
						Modified = DateTime.Parse("10-9-2019"),
						CreatedBy = "Corrine Hickle",
						ModifiedBy = "Bryce Hammes",
						PatientId = 34
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-22-2020"),
						MedicationName = "10 ML Furosemide 10 MG/ML Injection",
						Created = DateTime.Parse("3-16-2020"),
						Modified = DateTime.Parse("7-12-2020"),
						CreatedBy = "Lashonda Lind",
						ModifiedBy = "Margie Little",
						PatientId = 92
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-22-2019"),
						MedicationName = "12 HR Cefaclor 500 MG Extended Release Oral Tablet",
						Created = DateTime.Parse("12-19-2019"),
						Modified = DateTime.Parse("4-16-2020"),
						CreatedBy = "Ayesha Kuvalis",
						ModifiedBy = "Merle Schinner",
						PatientId = 61
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-28-2019"),
						MedicationName = "Insulin Lispro 100 UNT/ML Injectable Solution [Humalog]",
						Created = DateTime.Parse("10-24-2019"),
						Modified = DateTime.Parse("1-30-2020"),
						CreatedBy = "Jamaal Funk",
						ModifiedBy = "Hans Lindgren",
						PatientId = 2
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-25-2020"),
						MedicationName = "100 ML Epirubicin Hydrochloride 2 MG/ML Injection",
						Created = DateTime.Parse("7-9-2020"),
						Modified = DateTime.Parse("10-28-2020"),
						CreatedBy = "Jamaal Funk",
						ModifiedBy = "Evan Rath",
						PatientId = 26
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-1-2020"),
						MedicationName = "Sertraline 100MG",
						Created = DateTime.Parse("11-3-2020"),
						Modified = DateTime.Parse("2-9-2021"),
						CreatedBy = "Jorge Tamez",
						ModifiedBy = "Azalee Reichel",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-3-2020"),
						MedicationName = "letrozole 2.5 MG Oral Tablet",
						Created = DateTime.Parse("1-11-2021"),
						Modified = DateTime.Parse("3-5-2021"),
						CreatedBy = "Lois Sipes",
						ModifiedBy = "Kendal Bahringer",
						PatientId = 92
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-28-2019"),
						MedicationName = "predniSONE 5 MG Oral Tablet",
						Created = DateTime.Parse("1-26-2020"),
						Modified = DateTime.Parse("3-20-2020"),
						CreatedBy = "Gregorio Alonzo",
						ModifiedBy = "Shane Heidenreich",
						PatientId = 35
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-24-2020"),
						MedicationName = "Cisplatin 50 MG Injection",
						Created = DateTime.Parse("7-16-2020"),
						Modified = DateTime.Parse("8-23-2020"),
						CreatedBy = "Mara�a Cristina Aguilera",
						ModifiedBy = "Hortensia Bogan",
						PatientId = 26
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-7-2020"),
						MedicationName = "pregabalin 100 MG Oral Capsule",
						Created = DateTime.Parse("9-29-2020"),
						Modified = DateTime.Parse("1-18-2021"),
						CreatedBy = "Coleman Hagenes",
						ModifiedBy = "Lacey Yundt",
						PatientId = 4
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-14-2019"),
						MedicationName = "10 ML Pamidronate Disodium 3 MG/ML Injection",
						Created = DateTime.Parse("5-24-2019"),
						Modified = DateTime.Parse("7-4-2019"),
						CreatedBy = "Jaime Zapata",
						ModifiedBy = "Inger Wolff",
						PatientId = 100
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-16-2020"),
						MedicationName = "0.65 ML medroxyprogesterone acetate 160 MG/ML Prefilled Syringe",
						Created = DateTime.Parse("1-10-2021"),
						Modified = DateTime.Parse("2-12-2021"),
						CreatedBy = "Marilu Delapaz",
						ModifiedBy = "Karly Gaylord",
						PatientId = 95
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-26-2019"),
						MedicationName = "Sertraline 100MG",
						Created = DateTime.Parse("4-5-2020"),
						Modified = DateTime.Parse("8-3-2020"),
						CreatedBy = "Linwood Kub",
						ModifiedBy = "Derick Marquardt",
						PatientId = 7
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-3-2019"),
						MedicationName = "Fentanyl",
						Created = DateTime.Parse("10-18-2019"),
						Modified = DateTime.Parse("11-19-2019"),
						CreatedBy = "Matilde Halvorson",
						ModifiedBy = "Debrah Wunsch",
						PatientId = 77
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-2-2020"),
						MedicationName = "Diazepam [Valium]",
						Created = DateTime.Parse("4-15-2020"),
						Modified = DateTime.Parse("8-7-2020"),
						CreatedBy = "Valentin Bergstrom",
						ModifiedBy = "Emil Hansen",
						PatientId = 14
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-13-2020"),
						MedicationName = "Remifentanil",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("2-2-2021"),
						CreatedBy = "Keesha Yost",
						ModifiedBy = "Roselia Bartell",
						PatientId = 59
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-4-2020"),
						MedicationName = "Verapamil Hydrochloride 40 MG",
						Created = DateTime.Parse("9-15-2020"),
						Modified = DateTime.Parse("11-6-2020"),
						CreatedBy = "Amee Mertz",
						ModifiedBy = "Etha Gulgowski",
						PatientId = 72
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-6-2019"),
						MedicationName = "Carbamazepine[Tegretol]",
						Created = DateTime.Parse("4-12-2019"),
						Modified = DateTime.Parse("6-22-2019"),
						CreatedBy = "Dagny Ledner",
						ModifiedBy = "Toma�s Montenegro",
						PatientId = 74
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-1-2020"),
						MedicationName = "Milnacipran hydrochloride 100 MG [Savella]",
						Created = DateTime.Parse("12-18-2020"),
						Modified = DateTime.Parse("2-17-2021"),
						CreatedBy = "Beula Tillman",
						ModifiedBy = "Mika Roob",
						PatientId = 72
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-14-2020"),
						MedicationName = "1 ML medroxyprogesterone acetate 150 MG/ML Injection",
						Created = DateTime.Parse("2-5-2021"),
						Modified = DateTime.Parse("5-18-2021"),
						CreatedBy = "Merlin Smith",
						ModifiedBy = "Margarite Pfannerstill",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-3-2020"),
						MedicationName = "Sodium Chloride 9 MG/ML Injectable Solution",
						Created = DateTime.Parse("3-9-2020"),
						Modified = DateTime.Parse("4-17-2020"),
						CreatedBy = "Dewey Schowalter",
						ModifiedBy = "Tyrone Mohr",
						PatientId = 23
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-7-2019"),
						MedicationName = "Chlorpheniramine Maleate 2 MG/ML Oral Solution",
						Created = DateTime.Parse("8-26-2019"),
						Modified = DateTime.Parse("10-30-2019"),
						CreatedBy = "Sarah Rau",
						ModifiedBy = "Kerri Becker",
						PatientId = 39
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-30-2019"),
						MedicationName = "0.65 ML medroxyprogesterone acetate 160 MG/ML Prefilled Syringe",
						Created = DateTime.Parse("6-17-2019"),
						Modified = DateTime.Parse("7-26-2019"),
						CreatedBy = "Malinda Bosco",
						ModifiedBy = "Tyler Walter",
						PatientId = 4
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-23-2019"),
						MedicationName = "Colchicine 0.6 MG [Colcrys]",
						Created = DateTime.Parse("1-30-2020"),
						Modified = DateTime.Parse("5-9-2020"),
						CreatedBy = "Minda Greenfelder",
						ModifiedBy = "Francesca Purdy",
						PatientId = 49
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-2-2020"),
						MedicationName = "Fexofenadine hydrochloride 30 MG Oral Tablet",
						Created = DateTime.Parse("10-20-2020"),
						Modified = DateTime.Parse("1-21-2021"),
						CreatedBy = "Florinda Beahan",
						ModifiedBy = "Cecil Huel",
						PatientId = 88
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-26-2019"),
						MedicationName = "Fexofenadine hydrochloride 60 MG Oral Tablet",
						Created = DateTime.Parse("5-28-2019"),
						Modified = DateTime.Parse("7-13-2019"),
						CreatedBy = "Tracy Von",
						ModifiedBy = "Aracelis Connelly",
						PatientId = 47
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-12-2019"),
						MedicationName = "Naproxen sodium 220 MG Oral Tablet",
						Created = DateTime.Parse("9-22-2019"),
						Modified = DateTime.Parse("12-9-2019"),
						CreatedBy = "Isabel Carrasco",
						ModifiedBy = "Tiana Hoeger",
						PatientId = 74
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-30-2019"),
						MedicationName = "Yaz 28 Day Pack",
						Created = DateTime.Parse("9-7-2019"),
						Modified = DateTime.Parse("12-12-2019"),
						CreatedBy = "Jordon McKenzie",
						ModifiedBy = "Efren Hilll",
						PatientId = 47
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-5-2020"),
						MedicationName = "Chlorpheniramine Maleate 2 MG/ML Oral Solution",
						Created = DateTime.Parse("8-6-2020"),
						Modified = DateTime.Parse("11-23-2020"),
						CreatedBy = "Morgan Farrell",
						ModifiedBy = "John Bradtke",
						PatientId = 19
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-12-2020"),
						MedicationName = "Memantine hydrochloride 2 MG/ML Oral Solution",
						Created = DateTime.Parse("4-9-2020"),
						Modified = DateTime.Parse("5-16-2020"),
						CreatedBy = "Caesar Serrato",
						ModifiedBy = "Lyman Turner",
						PatientId = 46
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-9-2020"),
						MedicationName = "Atenolol 50 MG / Chlorthalidone 25 MG Oral Tablet",
						Created = DateTime.Parse("5-21-2020"),
						Modified = DateTime.Parse("8-14-2020"),
						CreatedBy = "Rema Parker",
						ModifiedBy = "Carey Deckow",
						PatientId = 39
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-19-2019"),
						MedicationName = "Kyleena 19.5 MG Intrauterine System",
						Created = DateTime.Parse("1-3-2020"),
						Modified = DateTime.Parse("2-11-2020"),
						CreatedBy = "Riley Deckow",
						ModifiedBy = "Willie Haag",
						PatientId = 63
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-10-2020"),
						MedicationName = "Donepezil hydrochloride 23 MG [Aricept]",
						Created = DateTime.Parse("4-8-2021"),
						Modified = DateTime.Parse("5-21-2021"),
						CreatedBy = "Lizabeth O'Conner",
						ModifiedBy = "Elvira Johns",
						PatientId = 78
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-13-2020"),
						MedicationName = "Cefuroxime 250 MG Oral Tablet",
						Created = DateTime.Parse("12-26-2020"),
						Modified = DateTime.Parse("2-8-2021"),
						CreatedBy = "Toshiko Purdy",
						ModifiedBy = "Miki Fadel",
						PatientId = 67
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-13-2020"),
						MedicationName = "Liletta 52 MG Intrauterine System",
						Created = DateTime.Parse("6-23-2020"),
						Modified = DateTime.Parse("9-18-2020"),
						CreatedBy = "Phil Mosciski",
						ModifiedBy = "Traci Jones",
						PatientId = 95
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-21-2020"),
						MedicationName = "insulin human  isophane 70 UNT/ML / Regular Insulin  Human 30 UNT/ML Injectable Suspension [Humulin]",
						Created = DateTime.Parse("3-30-2020"),
						Modified = DateTime.Parse("5-9-2020"),
						CreatedBy = "Sena Rogahn",
						ModifiedBy = "Dante Leffler",
						PatientId = 87
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-21-2019"),
						MedicationName = "100 ML Propofol 10 MG/ML Injection",
						Created = DateTime.Parse("9-17-2019"),
						Modified = DateTime.Parse("10-30-2019"),
						CreatedBy = "Marcela Merino",
						ModifiedBy = "Mason Quitzon",
						PatientId = 70
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-12-2020"),
						MedicationName = "letrozole 2.5 MG Oral Tablet",
						Created = DateTime.Parse("2-24-2021"),
						Modified = DateTime.Parse("5-24-2021"),
						CreatedBy = "Vito Reinger",
						ModifiedBy = "Jamar Oberbrunner",
						PatientId = 84
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-16-2020"),
						MedicationName = "NuvaRing 0.12/0.015 MG per 24HR 21 Day Vaginal Ring",
						Created = DateTime.Parse("7-18-2020"),
						Modified = DateTime.Parse("9-23-2020"),
						CreatedBy = "Diego Weber",
						ModifiedBy = "Antone Howe",
						PatientId = 62
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-7-2019"),
						MedicationName = "Verapamil Hydrochloride 40 MG",
						Created = DateTime.Parse("10-14-2019"),
						Modified = DateTime.Parse("12-16-2019"),
						CreatedBy = "Anthony Farrell",
						ModifiedBy = "Gail Davis",
						PatientId = 61
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-26-2020"),
						MedicationName = "anastrozole 1 MG Oral Tablet",
						Created = DateTime.Parse("10-3-2020"),
						Modified = DateTime.Parse("11-9-2020"),
						CreatedBy = "Garret Johnson",
						ModifiedBy = "Sherlene Nienow",
						PatientId = 25
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-3-2019"),
						MedicationName = "100 ML Epirubicin Hydrochloride 2 MG/ML Injection",
						Created = DateTime.Parse("10-24-2019"),
						Modified = DateTime.Parse("12-22-2019"),
						CreatedBy = "Barbra Mills",
						ModifiedBy = "Laura Colunga",
						PatientId = 28
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-7-2020"),
						MedicationName = "Rocuronium bromide 10 MG/ML Injectable Solution",
						Created = DateTime.Parse("6-20-2020"),
						Modified = DateTime.Parse("7-23-2020"),
						CreatedBy = "Oda Harvey",
						ModifiedBy = "Gwyn Hand",
						PatientId = 9
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-8-2020"),
						MedicationName = "Alteplase 100 MG Injection",
						Created = DateTime.Parse("3-6-2021"),
						Modified = DateTime.Parse("4-21-2021"),
						CreatedBy = "Genaro Parisian",
						ModifiedBy = "Ana Mara�a Trujillo",
						PatientId = 95
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-9-2019"),
						MedicationName = "Leucovorin 100 MG Injection",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("11-20-2019"),
						CreatedBy = "Daniel Arevalo",
						ModifiedBy = "Amie Swift",
						PatientId = 23
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-13-2020"),
						MedicationName = "Leucovorin 100 MG Injection",
						Created = DateTime.Parse("11-17-2020"),
						Modified = DateTime.Parse("2-27-2021"),
						CreatedBy = "Bella Mann",
						ModifiedBy = "Elvira Garrido",
						PatientId = 55
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-18-2019"),
						MedicationName = "Amlodipine 5 MG Oral Tablet",
						Created = DateTime.Parse("4-30-2019"),
						Modified = DateTime.Parse("6-29-2019"),
						CreatedBy = "Hyman Lang",
						ModifiedBy = "Lenna Zemlak",
						PatientId = 100
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-17-2019"),
						MedicationName = "Paclitaxel 100 MG Injection",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("5-27-2020"),
						CreatedBy = "Julio Powlowski",
						ModifiedBy = "Carson Wisozk",
						PatientId = 3
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-24-2019"),
						MedicationName = "5 ML hyaluronidase-oysk 2000 UNT/ML / trastuzumab 120 MG/ML Injection",
						Created = DateTime.Parse("12-13-2019"),
						Modified = DateTime.Parse("2-17-2020"),
						CreatedBy = "Shantelle Ruecker",
						ModifiedBy = "Natalya Wiegand",
						PatientId = 1
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-17-2020"),
						MedicationName = "10 ML oxaliplatin 5 MG/ML Injection",
						Created = DateTime.Parse("10-2-2020"),
						Modified = DateTime.Parse("1-25-2021"),
						CreatedBy = "Coleman Cole",
						ModifiedBy = "Arica Windler",
						PatientId = 24
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-10-2019"),
						MedicationName = "Nitrofurantoin 5 MG/ML Oral Suspension",
						Created = DateTime.Parse("3-4-2020"),
						Modified = DateTime.Parse("4-19-2020"),
						CreatedBy = "Norris O'Connell",
						ModifiedBy = "Amado Dibbert",
						PatientId = 31
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-17-2020"),
						MedicationName = "Natazia 28 Day Pack",
						Created = DateTime.Parse("1-19-2021"),
						Modified = DateTime.Parse("3-6-2021"),
						CreatedBy = "Oliver Barton",
						ModifiedBy = "Duane Runte",
						PatientId = 64
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-17-2019"),
						MedicationName = "10 ML Doxorubicin Hydrochloride 2 MG/ML Injection",
						Created = DateTime.Parse("4-18-2019"),
						Modified = DateTime.Parse("5-27-2019"),
						CreatedBy = "Carlita Mueller",
						ModifiedBy = "Tommy Metz",
						PatientId = 25
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-14-2020"),
						MedicationName = "Acetaminophen 325 MG / oxyCODONE Hydrochloride 2.5 MG [Percocet]",
						Created = DateTime.Parse("4-19-2020"),
						Modified = DateTime.Parse("6-19-2020"),
						CreatedBy = "Gonzalo Crona",
						ModifiedBy = "Luis Miguel Echevarra�a",
						PatientId = 16
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-16-2020"),
						MedicationName = "Acetaminophen 325 MG Oral Tablet",
						Created = DateTime.Parse("10-4-2020"),
						Modified = DateTime.Parse("11-7-2020"),
						CreatedBy = "Salina Kozey",
						ModifiedBy = "Adrian Rice",
						PatientId = 86
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-30-2019"),
						MedicationName = "Acetaminophen 325 MG Oral Tablet",
						Created = DateTime.Parse("12-23-2019"),
						Modified = DateTime.Parse("3-20-2020"),
						CreatedBy = "Earl Moen",
						ModifiedBy = "Alonso Beer",
						PatientId = 15
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-17-2019"),
						MedicationName = "Lasix 40mg",
						Created = DateTime.Parse("4-24-2019"),
						Modified = DateTime.Parse("6-16-2019"),
						CreatedBy = "Rebecca Kessler",
						ModifiedBy = "Alva Swift",
						PatientId = 93
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-1-2020"),
						MedicationName = "Clopidogrel 75 MG Oral Tablet",
						Created = DateTime.Parse("7-13-2020"),
						Modified = DateTime.Parse("9-12-2020"),
						CreatedBy = "Ayesha Roberts",
						ModifiedBy = "Lindsay Pagac",
						PatientId = 72
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-12-2019"),
						MedicationName = "atomoxetine 100 MG Oral Capsule",
						Created = DateTime.Parse("8-15-2019"),
						Modified = DateTime.Parse("11-28-2019"),
						CreatedBy = "Hobert Pacocha",
						ModifiedBy = "Carrol Berge",
						PatientId = 35
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-25-2020"),
						MedicationName = "Vitamin B 12 5 MG/ML Injectable Solution",
						Created = DateTime.Parse("8-21-2020"),
						Modified = DateTime.Parse("10-30-2020"),
						CreatedBy = "Luciano Wiza",
						ModifiedBy = "Luis Miguel Montalvo",
						PatientId = 18
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-6-2020"),
						MedicationName = "letrozole 2.5 MG Oral Tablet",
						Created = DateTime.Parse("10-13-2020"),
						Modified = DateTime.Parse("12-4-2020"),
						CreatedBy = "Kym Runolfsson",
						ModifiedBy = "Rubie Braun",
						PatientId = 77
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-15-2019"),
						MedicationName = "3 ML Amiodarone hydrocholoride 50 MG/ML Prefilled Syringe",
						Created = DateTime.Parse("2-12-2020"),
						Modified = DateTime.Parse("4-7-2020"),
						CreatedBy = "Gayle Leannon",
						ModifiedBy = "Otha Stark",
						PatientId = 16
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-23-2019"),
						MedicationName = "Sertraline 100MG",
						Created = DateTime.Parse("7-1-2019"),
						Modified = DateTime.Parse("10-26-2019"),
						CreatedBy = "Shera Konopelski",
						ModifiedBy = "Max Pouros",
						PatientId = 46
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-29-2020"),
						MedicationName = "Amlodipine 5 MG / Hydrochlorothiazide 12.5 MG / Olmesartan medoxomil 20 MG",
						Created = DateTime.Parse("3-23-2021"),
						Modified = DateTime.Parse("4-22-2021"),
						CreatedBy = "Kizzie Bosco",
						ModifiedBy = "Bernardo Cortaes",
						PatientId = 51
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-15-2019"),
						MedicationName = "3 ML Amiodarone hydrocholoride 50 MG/ML Prefilled Syringe",
						Created = DateTime.Parse("10-20-2019"),
						Modified = DateTime.Parse("1-12-2020"),
						CreatedBy = "Edwin Waters",
						ModifiedBy = "Nelida Eichmann",
						PatientId = 94
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-11-2019"),
						MedicationName = "sevoflurane 1000 MG/ML Inhalant Solution",
						Created = DateTime.Parse("4-27-2019"),
						Modified = DateTime.Parse("8-20-2019"),
						CreatedBy = "Dallas Beatty",
						ModifiedBy = "Ferdinand Lemke",
						PatientId = 98
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-24-2019"),
						MedicationName = "Verapamil Hydrochloride 40 MG",
						Created = DateTime.Parse("6-16-2019"),
						Modified = DateTime.Parse("8-17-2019"),
						CreatedBy = "Antoine Bahringer",
						ModifiedBy = "Lydia Morissette",
						PatientId = 65
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-4-2019"),
						MedicationName = "Vitamin B 12 5 MG/ML Injectable Solution",
						Created = DateTime.Parse("12-3-2019"),
						Modified = DateTime.Parse("2-3-2020"),
						CreatedBy = "Lynsey Koelpin",
						ModifiedBy = "Clarita Kuvalis",
						PatientId = 43
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-13-2019"),
						MedicationName = "Leucovorin 100 MG Injection",
						Created = DateTime.Parse("6-10-2019"),
						Modified = DateTime.Parse("9-15-2019"),
						CreatedBy = "Amalia Herzog",
						ModifiedBy = "Miquel Auer",
						PatientId = 89
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-18-2019"),
						MedicationName = "24 HR Metformin hydrochloride 500 MG Extended Release Oral Tablet",
						Created = DateTime.Parse("9-11-2019"),
						Modified = DateTime.Parse("11-4-2019"),
						CreatedBy = "Myong Crooks",
						ModifiedBy = "Susana Lockman",
						PatientId = 86
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-5-2020"),
						MedicationName = "Amoxicillin 250 MG / Clavulanate 125 MG Oral Tablet",
						Created = DateTime.Parse("11-7-2020"),
						Modified = DateTime.Parse("12-19-2020"),
						CreatedBy = "Michaela Sauer",
						ModifiedBy = "Phillip Parker",
						PatientId = 90
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-17-2020"),
						MedicationName = "Ibuprofen 100 MG Oral Tablet",
						Created = DateTime.Parse("4-28-2020"),
						Modified = DateTime.Parse("6-9-2020"),
						CreatedBy = "Carolann Purdy",
						ModifiedBy = "Marion Bosco",
						PatientId = 53
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("3-25-2019"),
						MedicationName = "Trinessa 28 Day Pack",
						Created = DateTime.Parse("6-19-2019"),
						Modified = DateTime.Parse("8-18-2019"),
						CreatedBy = "Miguel a�ngel Mojica",
						ModifiedBy = "Matilde Adams",
						PatientId = 63
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-4-2019"),
						MedicationName = "Nitroglycerin 0.4 MG/ACTUAT Mucosal Spray",
						Created = DateTime.Parse("1-4-2020"),
						Modified = DateTime.Parse("3-10-2020"),
						CreatedBy = "Terese Reynolds",
						ModifiedBy = "Merrie Beier",
						PatientId = 29
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("6-28-2020"),
						MedicationName = "Penicillin V Potassium 250 MG Oral Tablet",
						Created = DateTime.Parse("8-23-2020"),
						Modified = DateTime.Parse("10-7-2020"),
						CreatedBy = "Setsuko Kemmer",
						ModifiedBy = "Laurice Schumm",
						PatientId = 82
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-7-2019"),
						MedicationName = "12 HR Cefaclor 500 MG Extended Release Oral Tablet",
						Created = DateTime.Parse("12-24-2019"),
						Modified = DateTime.Parse("4-20-2020"),
						CreatedBy = "Leila Heidenreich",
						ModifiedBy = "Hoyt Witting",
						PatientId = 75
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-14-2020"),
						MedicationName = "Atropine Sulfate 1 MG/ML Injectable Solution",
						Created = DateTime.Parse("11-19-2020"),
						Modified = DateTime.Parse("3-2-2021"),
						CreatedBy = "Arletta Stanton",
						ModifiedBy = "Lia Considine",
						PatientId = 92
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("9-27-2019"),
						MedicationName = "60 ACTUAT Fluticasone propionate 0.25 MG/ACTUAT / salmeterol 0.05 MG/ACTUAT Dry Powder Inhaler",
						Created = DateTime.Parse("11-11-2019"),
						Modified = DateTime.Parse("1-9-2020"),
						CreatedBy = "Asa Tillman",
						ModifiedBy = "Tandy Yundt",
						PatientId = 60
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-17-2019"),
						MedicationName = "Levothyroxine Sodium 0.075 MG Oral Tablet",
						Created = DateTime.Parse("12-5-2019"),
						Modified = DateTime.Parse("2-7-2020"),
						CreatedBy = "Audry Heathcote",
						ModifiedBy = "Lyndia Kohler",
						PatientId = 47
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-26-2019"),
						MedicationName = "Acetaminophen 325 MG Oral Tablet",
						Created = DateTime.Parse("3-25-2020"),
						Modified = DateTime.Parse("5-20-2020"),
						CreatedBy = "Daisey Pfeffer",
						ModifiedBy = "Catarina McCullough",
						PatientId = 59
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-24-2019"),
						MedicationName = "Simvastatin 20 MG Oral Tablet",
						Created = DateTime.Parse("10-25-2019"),
						Modified = DateTime.Parse("1-31-2020"),
						CreatedBy = "Arlinda Monahan",
						ModifiedBy = "Maryellen Christiansen",
						PatientId = 81
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("4-16-2019"),
						MedicationName = "1 ML Epoetin Alfa 4000 UNT/ML Injection [Epogen]",
						Created = DateTime.Parse("8-3-2019"),
						Modified = DateTime.Parse("11-9-2019"),
						CreatedBy = "Eusebio Wilkinson",
						ModifiedBy = "Maybell Durgan",
						PatientId = 34
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-20-2019"),
						MedicationName = "Lasix 40mg",
						Created = DateTime.Parse("2-3-2020"),
						Modified = DateTime.Parse("4-1-2020"),
						CreatedBy = "Vernon Kovacek",
						ModifiedBy = "Sara Pouros",
						PatientId = 75
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-30-2020"),
						MedicationName = "Errin 28 Day Pack",
						Created = DateTime.Parse("11-12-2020"),
						Modified = DateTime.Parse("2-5-2021"),
						CreatedBy = "Ada Wiegand",
						ModifiedBy = "Edgar Jaskolski",
						PatientId = 25
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-4-2019"),
						MedicationName = "Amlodipine 5 MG / Hydrochlorothiazide 12.5 MG / Olmesartan medoxomil 20 MG",
						Created = DateTime.Parse("9-3-2019"),
						Modified = DateTime.Parse("11-23-2019"),
						CreatedBy = "Jerrold Heathcote",
						ModifiedBy = "Bennie Rutherford",
						PatientId = 74
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-14-2020"),
						MedicationName = "Amoxicillin 250 MG Oral Capsule",
						Created = DateTime.Parse("1-24-2021"),
						Modified = DateTime.Parse("3-21-2021"),
						CreatedBy = "Booker Lebsack",
						ModifiedBy = "Mara�a del Carmen Casares",
						PatientId = 55
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-11-2019"),
						MedicationName = "Fexofenadine hydrochloride 60 MG Oral Tablet",
						Created = DateTime.Parse("8-30-2019"),
						Modified = DateTime.Parse("11-8-2019"),
						CreatedBy = "Keely Emmerich",
						ModifiedBy = "Willetta Jacobi",
						PatientId = 31
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-8-2019"),
						MedicationName = "Tamoxifen 10 MG Oral Tablet",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("12-29-2019"),
						CreatedBy = "Whitley Ullrich",
						ModifiedBy = "Malcom Conroy",
						PatientId = 4
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-30-2020"),
						MedicationName = "Clonazepam [Klonopin]",
						Created = DateTime.Parse("10-10-2020"),
						Modified = DateTime.Parse("1-7-2021"),
						CreatedBy = "Hobert Brakus",
						ModifiedBy = "Nan Frami",
						PatientId = 31
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("5-13-2019"),
						MedicationName = "Alfentanil",
						Created = DateTime.Parse("7-25-2019"),
						Modified = DateTime.Parse("9-13-2019"),
						CreatedBy = "Inocencia Auer",
						ModifiedBy = "Tuan Greenholt",
						PatientId = 72
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("2-13-2020"),
						MedicationName = "Ibuprofen 200 MG Oral Tablet",
						Created = DateTime.Parse("6-6-2020"),
						Modified = DateTime.Parse("9-15-2020"),
						CreatedBy = "Earnest Paucek",
						ModifiedBy = "Bertha Franecki",
						PatientId = 66
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-9-2020"),
						MedicationName = "Acetaminophen 300 MG / HYDROcodone Bitartrate 5 MG [Vicodin]",
						Created = DateTime.Parse("1-17-2021"),
						Modified = DateTime.Parse("4-23-2021"),
						CreatedBy = "Franklin Ratke",
						ModifiedBy = "Lindsay Schiller",
						PatientId = 96
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-29-2020"),
						MedicationName = "Warfarin Sodium 5 MG Oral Tablet",
						Created = DateTime.Parse("2-9-2021"),
						Modified = DateTime.Parse("5-24-2021"),
						CreatedBy = "Nicolais Lugo",
						ModifiedBy = "Altagracia Hudson",
						PatientId = 28
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("1-14-2019"),
						MedicationName = "NDA020800 0.3 ML Epinephrine 1 MG/ML Auto-Injector",
						Created = DateTime.Parse("4-20-2019"),
						Modified = DateTime.Parse("6-16-2019"),
						CreatedBy = "Coy Ratke",
						ModifiedBy = "Bridget Hahn",
						PatientId = 32
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-31-2019"),
						MedicationName = "Yaz 28 Day Pack",
						Created = DateTime.Parse("11-4-2019"),
						Modified = DateTime.Parse("1-3-2020"),
						CreatedBy = "Ricki Blick",
						ModifiedBy = "Natalya Wiegand",
						PatientId = 80
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("11-13-2020"),
						MedicationName = "Tacrine 10 MG Oral Capsule",
						Created = DateTime.Parse("3-3-2021"),
						Modified = DateTime.Parse("4-21-2021"),
						CreatedBy = "Harmony Hammes",
						ModifiedBy = "Mason Schumm",
						PatientId = 15
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-27-2020"),
						MedicationName = "Rocuronium bromide 10 MG/ML Injectable Solution",
						Created = DateTime.Parse("12-1-2020"),
						Modified = DateTime.Parse("2-24-2021"),
						CreatedBy = "Brandie Wehner",
						ModifiedBy = "Norbert O'Hara",
						PatientId = 51
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-13-2019"),
						MedicationName = "Etoposide 100 MG Injection",
						Created = DateTime.Parse("12-7-2019"),
						Modified = DateTime.Parse("2-19-2020"),
						CreatedBy = "Misha Koelpin",
						ModifiedBy = "Alexis Crona",
						PatientId = 12
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("7-28-2019"),
						MedicationName = "cetirizine hydrochloride 5 MG Oral Tablet",
						Created = DateTime.Parse("9-4-2019"),
						Modified = DateTime.Parse("11-17-2019"),
						CreatedBy = "Ernesto Gonzales",
						ModifiedBy = "Una Hilpert",
						PatientId = 46
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-13-2020"),
						MedicationName = "atomoxetine 100 MG Oral Capsule",
						Created = DateTime.Parse("10-15-2020"),
						Modified = DateTime.Parse("12-25-2020"),
						CreatedBy = "Maire Block",
						ModifiedBy = "Jame Fay",
						PatientId = 37
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("8-15-2020"),
						MedicationName = "exemestane 25 MG Oral Tablet",
						Created = DateTime.Parse("10-16-2020"),
						Modified = DateTime.Parse("12-20-2020"),
						CreatedBy = "Candra Kertzmann",
						ModifiedBy = "Silva Baumbach",
						PatientId = 43
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("12-29-2019"),
						MedicationName = "NDA020800 0.3 ML Epinephrine 1 MG/ML Auto-Injector",
						Created = DateTime.Parse("3-17-2020"),
						Modified = DateTime.Parse("4-16-2020"),
						CreatedBy = "Kasey Kohler",
						ModifiedBy = "Mose O'Conner",
						PatientId = 15
					},
				new Medication
					{
						MedicationDate = DateTime.Parse("10-24-2019"),
						MedicationName = "1 ML medroxyprogesterone acetate 150 MG/ML Injection",
						Created = DateTime.Parse("2-8-2020"),
						Modified = DateTime.Parse("5-5-2020"),
						CreatedBy = "Lucius Corkery",
						ModifiedBy = "Benito Rendaen",
						PatientId = 14
					}
				};
			medications.ForEach(m => context.Medications.AddOrUpdate(m));
			context.SaveChanges();
			}
		}
	}
