﻿using System;
using System.Data.Entity;
using PaulStoryCylanceCodingTest.Models;

namespace PaulStoryCylanceCodingTest.Data.Configurations
{
    public class CustomDatabaseInitializer  :
        CreateDatabaseIfNotExists<DataContext>
        {
            private enum ProdColumns
            {
                ProductID,
                ProductName,
                SupplierID,
                CategoryID,
                QuantityPerUnit,
                UnitPrice,
                UnitsInStock,
                UnitsOnOrder,
                ReorderLevel,
                Discontinued
            }

            private enum SuppColumns
            {
                SupplierID,
                CompanyName,
                ContactName,
                ContactTitle,
                Address,
                City,
                Region,
                PostalCode,
                Country,
                Phone,
                Fax,
                HomePage
            }

            protected override void Seed(DataContext context)
            {
                string[] suppValues = new string[29]
                {
                "1,Exotic Liquids,Charlotte Cooper,Purchasing Manager,49 Gilbert St.,London,,EC1 4SD,UK,(171) 555-2222,,,",
                "2,New Orleans Cajun Delights,Shelley Burke,Order Administrator,P.O. Box 78934,New Orleans,LA,70117,USA,(100) 555-4822,,#CAJUN.HTM#,",
                "3,Grandma Kelly's Homestead,Regina Murphy,Sales Representative,707 Oxford Rd.,Ann Arbor,MI,48104,USA,(313) 555-5735,(313) 555-3349,,",
                "4,Tokyo Traders,Yoshi Nagase,Marketing Manager,9-8 Sekimai Musashino-shi,Tokyo,,100,Japan,(03) 3555-5011,,,",
                "5,Cooperativa de Quesos 'Las Cabras',Antonio del Valle Saavedra,Export Administrator,Calle del Rosal 4,Oviedo,Asturias,33007,Spain,(98) 598 76 54,,,",
                "6,Mayumi's,Mayumi Ohno,Marketing Representative,92 Setsuko Chuo-ku,Osaka,,545,Japan,(06) 431-7877,,Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#,",
                "7,Pavlova Ltd.,Ian Devling,Marketing Manager,74 Rose St. Moonie Ponds,Melbourne,Victoria,3058,Australia,(03) 444-2343,(03) 444-6588,,",
                "8,Specialty Biscuits Ltd.,Peter Wilson,Sales Representative,29 King's Way,Manchester,,M14 GSD,UK,(161) 555-4448,,,",
                "9,PB Knäckebröd AB,Lars Peterson,Sales Agent,Kaloadagatan 13,Göteborg,,S-345 67,Sweden,031-987 65 43,031-987 65 91,,",
                "10,Refrescos Americanas LTDA,Carlos Diaz,Marketing Manager,Av. das Americanas 12.890,Sao Paulo,,5442,Brazil,(11) 555 4640,,,",
                "11,Heli Süßwaren GmbH & Co. KG,Petra Winkler,Sales Manager,Tiergartenstraße 5,Berlin,,10785,Germany,(010) 9984510,,,",
                "12,Plutzer Lebensmittelgroßmärkte AG,Martin Bein,International Marketing Mgr.,Bogenallee 51,Frankfurt,,60439,Germany,(069) 992755,,Plutzer (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/plutzer.htm#,",
                "13,Nord-Ost-Fisch Handelsgesellschaft mbH,Sven Petersen,Coordinator Foreign Markets,Frahmredder 112a,Cuxhaven,,27478,Germany,(04721) 8713,(04721) 8714,,",
                "14,Formaggi Fortini s.r.l.,Elio Rossi,Sales Representative,Viale Dante 75,Ravenna,,48100,Italy,(0544) 60323,(0544) 60603,#FORMAGGI.HTM#,",
                "15,Norske Meierier,Beate Vileid,Marketing Manager,Hatlevegen 5,Sandvika,,1320,Norway,(0)2-953010,,,",
                "16,Bigfoot Breweries,Cheryl Saylor,Regional Account Rep.,3400 - 8th Avenue Suite 210,Bend,OR,97101,USA,(503) 555-9931,,,",
                "17,Svensk Sjöföda AB,Michael Björn,Sales Representative,Brovallavägen 231,Stockholm,,S-123 45,Sweden,08-123 45 67,,,",
                "18,Aux joyeux ecclésiastiques,Guylène Nodier,Sales Manager,203 Rue des Francs-Bourgeois,Paris,,75004,France,(1) 03.83.00.68,(1) 03.83.00.62,,",
                "19,New England Seafood Cannery,Robb Merchant,Wholesale Account Agent,Order Processing Dept. 2100 Paul Revere Blvd.,Boston,MA,02134,USA,(617) 555-3267,(617) 555-3389,,",
                "20,Leka Trading,Chandra Leka,Owner,471 Serangoon Loop Suite #402,Singapore,,0512,Singapore,555-8787,,,",
                "21,Lyngbysild,Niels Petersen,Sales Manager,Lyngbysild Fiskebakken 10,Lyngby,,2800,Denmark,43844108,43844115,,",
                "22,Zaanse Snoepfabriek,Dirk Luchte,Accounting Manager,Verkoop Rijnweg 22,Zaandam,,9999 ZZ,Netherlands,(12345) 1212,(12345) 1210,,",
                "23,Karkki Oy,Anne Heikkonen,Product Manager,Valtakatu 12,Lappeenranta,,53120,Finland,(953) 10956,,,",
                "24,G'day Mate,Wendy Mackenzie,Sales Representative,170 Prince Edward Parade Hunter's Hill,Sydney,NSW,2042,Australia,(02) 555-5914,(02) 555-4873,G'day Mate (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/gdaymate.htm#,",
                "25,Ma Maison,Jean-Guy Lauzon,Marketing Manager,2960 Rue St. Laurent,Montréal,Québec,H1J 1C3,Canada,(514) 555-9022,,,",
                "26,Pasta Buttini s.r.l.,Giovanni Giudici,Order Administrator,Via dei Gelsomini 153,Salerno,,84100,Italy,(089) 6547665,(089) 6547667,,",
                "27,Escargots Nouveaux,Marie Delamare,Sales Manager,22 rue H. Voiron,Montceau,,71300,France,85.57.00.07,,,",
                "28,Gai pâturage,Eliane Noz,Sales Representative,Bat. B 3 rue des Alpes,Annecy,,74000,France,38.76.98.06,38.76.98.58,,",
                "29,Forêts d'érables,Chantal Goulet,Accounting Manager,148 rue Chasseur,Ste-Hyacinthe,Québec,J2S 7S8,Canada,(514) 555-2955,(514) 555-2921,,"
                };

                string[] prodValues = new string[77]
                {
                "1,Chai,1,1,10 boxes x 20 bags,18.00,39,0,10,0",
                "2,Chang,1,1,24 - 12 oz bottles,19.00,17,40,25,0",
                "3,Aniseed Syrup,1,2,12 - 550 ml bottles,10.00,13,70,25,0",
                "4,Chef Anton's Cajun Seasoning,2,2,48 - 6 oz jars,22.00,53,0,0,0",
                "5,Chef Anton's Gumbo Mix,2,2,36 boxes,21.35,0,0,0,1",
                "6,Grandma's Boysenberry Spread,3,2,12 - 8 oz jars,25.00,120,0,25,0",
                "7,Uncle Bob's Organic Dried Pears,3,7,12 - 1 lb pkgs.,30.00,15,0,10,0",
                "8,Northwoods Cranberry Sauce,3,2,12 - 12 oz jars,40.00,6,0,0,0",
                "9,Mishi Kobe Niku,4,6,18 - 500 g pkgs.,97.00,29,0,0,1",
                "10,Ikura,4,8,12 - 200 ml jars,31.00,31,0,0,0",
                "11,Queso Cabrales,5,4,1 kg pkg.,21.00,22,30,30,0",
                "12,Queso Manchego La Pastora,5,4,10 - 500 g pkgs.,38.00,86,0,0,0",
                "13,Konbu,6,8,2 kg box,6.00,24,0,5,0",
                "14,Tofu,6,7,40 - 100 g pkgs.,23.25,35,0,0,0",
                "15,Genen Shouyu,6,2,24 - 250 ml bottles,15.50,39,0,5,0",
                "16,Pavlova,7,3,32 - 500 g boxes,17.45,29,0,10,0",
                "17,Alice Mutton,7,6,20 - 1 kg tins,39.00,0,0,0,1",
                "18,Carnarvon Tigers,7,8,16 kg pkg.,62.50,42,0,0,0",
                "19,Teatime Chocolate Biscuits,8,3,10 boxes x 12 pieces,9.20,25,0,5,0",
                "20,Sir Rodney's Marmalade,8,3,30 gift boxes,81.00,40,0,0,0",
                "21,Sir Rodney's Scones,8,3,24 pkgs. x 4 pieces,10.00,3,40,5,0",
                "22,Gustaf's Knäckebröd,9,5,24 - 500 g pkgs.,21.00,104,0,25,0",
                "23,Tunnbröd,9,5,12 - 250 g pkgs.,9.00,61,0,25,0",
                "24,Guaraná Fantástica,10,1,12 - 355 ml cans,4.50,20,0,0,1",
                "25,NuNuCa Nuß-Nougat-Creme,11,3,20 - 450 g glasses,14.00,76,0,30,0",
                "26,Gumbär Gummibärchen,11,3,100 - 250 g bags,31.23,15,0,0,0",
                "27,Schoggi Schokolade,11,3,100 - 100 g pieces,43.90,49,0,30,0",
                "28,Rössle Sauerkraut,12,7,25 - 825 g cans,45.60,26,0,0,1",
                "29,Thüringer Rostbratwurst,12,6,50 bags x 30 sausgs.,123.79,0,0,0,1",
                "30,Nord-Ost Matjeshering,13,8,10 - 200 g glasses,25.89,10,0,15,0",
                "31,Gorgonzola Telino,14,4,12 - 100 g pkgs,12.50,0,70,20,0",
                "32,Mascarpone Fabioli,14,4,24 - 200 g pkgs.,32.00,9,40,25,0",
                "33,Geitost,15,4,500 g,2.50,112,0,20,0",
                "34,Sasquatch Ale,16,1,24 - 12 oz bottles,14.00,111,0,15,0",
                "35,Steeleye Stout,16,1,24 - 12 oz bottles,18.00,20,0,15,0",
                "36,Inlagd Sill,17,8,24 - 250 g  jars,19.00,112,0,20,0",
                "37,Gravad lax,17,8,12 - 500 g pkgs.,26.00,11,50,25,0",
                "38,Côte de Blaye,18,1,12 - 75 cl bottles,263.50,17,0,15,0",
                "39,Chartreuse verte,18,1,750 cc per bottle,18.00,69,0,5,0",
                "40,Boston Crab Meat,19,8,24 - 4 oz tins,18.40,123,0,30,0",
                "41,Jack's New England Clam Chowder,19,8,12 - 12 oz cans,9.65,85,0,10,0",
                "42,Singaporean Hokkien Fried Mee,20,5,32 - 1 kg pkgs.,14.00,26,0,0,1",
                "43,Ipoh Coffee,20,1,16 - 500 g tins,46.00,17,10,25,0",
                "44,Gula Malacca,20,2,20 - 2 kg bags,19.45,27,0,15,0",
                "45,Rogede sild,21,8,1k pkg.,9.50,5,70,15,0",
                "46,Spegesild,21,8,4 - 450 g glasses,12.00,95,0,0,0",
                "47,Zaanse koeken,22,3,10 - 4 oz boxes,9.50,36,0,0,0",
                "48,Chocolade,22,3,10 pkgs.,12.75,15,70,25,0",
                "49,Maxilaku,23,3,24 - 50 g pkgs.,20.00,10,60,15,0",
                "50,Valkoinen suklaa,23,3,12 - 100 g bars,16.25,65,0,30,0",
                "51,Manjimup Dried Apples,24,7,50 - 300 g pkgs.,53.00,20,0,10,0",
                "52,Filo Mix,24,5,16 - 2 kg boxes,7.00,38,0,25,0",
                "53,Perth Pasties,24,6,48 pieces,32.80,0,0,0,1",
                "54,Tourtière,25,6,16 pies,7.45,21,0,10,0",
                "55,Pâté chinois,25,6,24 boxes x 2 pies,24.00,115,0,20,0",
                "56,Gnocchi di nonna Alice,26,5,24 - 250 g pkgs.,38.00,21,10,30,0",
                "57,Ravioli Angelo,26,5,24 - 250 g pkgs.,19.50,36,0,20,0",
                "58,Escargots de Bourgogne,27,8,24 pieces,13.25,62,0,20,0",
                "59,Raclette Courdavault,28,4,5 kg pkg.,55.00,79,0,0,0",
                "60,Camembert Pierrot,28,4,15 - 300 g rounds,34.00,19,0,0,0",
                "61,Sirop d'érable,29,2,24 - 500 ml bottles,28.50,113,0,25,0",
                "62,Tarte au sucre,29,3,48 pies,49.30,17,0,0,0",
                "63,Vegie-spread,7,2,15 - 625 g jars,43.90,24,0,5,0",
                "64,Wimmers gute Semmelknödel,12,5,20 bags x 4 pieces,33.25,22,80,30,0",
                "65,Louisiana Fiery Hot Pepper Sauce,2,2,32 - 8 oz bottles,21.05,76,0,0,0",
                "66,Louisiana Hot Spiced Okra,2,2,24 - 8 oz jars,17.00,4,100,20,0",
                "67,Laughing Lumberjack Lager,16,1,24 - 12 oz bottles,14.00,52,0,10,0",
                "68,Scottish Longbreads,8,3,10 boxes x 8 pieces,12.50,6,10,15,0",
                "69,Gudbrandsdalsost,15,4,10 kg pkg.,36.00,26,0,15,0",
                "70,Outback Lager,7,1,24 - 355 ml bottles,15.00,15,10,30,0",
                "71,Flotemysost,15,4,10 - 500 g pkgs.,21.50,26,0,0,0",
                "72,Mozzarella di Giovanni,14,4,24 - 200 g pkgs.,34.80,14,0,0,0",
                "73,Röd Kaviar,17,8,24 - 150 g jars,15.00,101,0,5,0",
                "74,Longlife Tofu,4,7,5 kg pkg.,10.00,4,20,5,0",
                "75,Rhönbräu Klosterbier,12,1,24 - 0.5 l bottles,7.75,125,0,25,0",
                "76,Lakkalikööri,23,1,500 ml,18.00,57,0,20,0",
                "77,Original Frankfurter grüne Soße,12,2,12 boxes,13.00,32,0,15,0"
                };

                //SEED PRODUCTS
                int length = prodValues.Length;

                for (int x = 0; x < length; x++)
                {
                    try
                    {
                        var row = prodValues[x].Split(',');

                        var prod = new Product
                        {
                            ProductID = Convert.ToInt32(row[(int)ProdColumns.ProductID]),
                            ProductName = row[(int)ProdColumns.ProductName],
                            SupplierID = Convert.ToInt32(row[(int)ProdColumns.SupplierID]),
                            CategoryID = Convert.ToInt32(row[(int)ProdColumns.CategoryID]),
                            QuantityPerUnit = row[(int)ProdColumns.QuantityPerUnit],
                            UnitPrice = Convert.ToDecimal(row[(int)ProdColumns.UnitPrice]),
                            UnitsInStock = Convert.ToInt16(row[(int)ProdColumns.UnitsInStock]),
                            UnitsOnOrder = Convert.ToInt16(row[(int)ProdColumns.UnitsOnOrder]),
                            ReorderLevel = Convert.ToInt16(row[(int)ProdColumns.ReorderLevel]),
                            Discontinued = Convert.ToBoolean(Convert.ToInt32(row[(int)ProdColumns.Discontinued]))
                        };

                        context.Products.Add(prod);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("ERROR NUMB: {0}", ex.HelpLink));
                        Console.WriteLine(string.Format("ERROR MESS: {0}", ex.Message));
                        Console.ReadLine();
                    }
                }

                //SEED SUPPLIERS
                length = suppValues.Length;
                for (int x = 0; x < length; x++)
                {
                    var row = suppValues[x].Split(',');

                    var supp = new Supplier
                    {
                        SupplierID = Convert.ToInt32(row[(int)SuppColumns.SupplierID]),
                        CompanyName = row[(int)SuppColumns.CompanyName],
                        ContactName = row[(int)SuppColumns.ContactName],
                        ContactTitle = row[(int)SuppColumns.ContactTitle],
                        Address = row[(int)SuppColumns.Address],
                        City = row[(int)SuppColumns.City],
                        Region = row[(int)SuppColumns.Region],
                        PostalCode = row[(int)SuppColumns.PostalCode],
                        Country = row[(int)SuppColumns.Country],
                        Phone = row[(int)SuppColumns.Phone],
                        Fax = row[(int)SuppColumns.Fax],
                        HomePage = row[(int)SuppColumns.HomePage]
                    };

                    //Console.WriteLine(string.Format("CITY: {0}", supp.City));
                    context.Suppliers.Add(supp);
                }

                base.Seed(context);
            }
        }
    }
