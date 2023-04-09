using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFA_ProDiet.DAL.Migrations
{
    public partial class migV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ActivityLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TargetWeight = table.Column<double>(type: "float", nullable: false),
                    TargetDate = table.Column<DateTime>(type: "date", nullable: false),
                    TargetCalorie = table.Column<double>(type: "float", nullable: false),
                    Bmr = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    MeasureType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EatDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealCalorie = table.Column<double>(type: "float", nullable: true),
                    MealCarbohydrate = table.Column<double>(type: "float", nullable: true),
                    MealProtein = table.Column<double>(type: "float", nullable: true),
                    MealFat = table.Column<double>(type: "float", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "MealDetails",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDetails", x => new { x.MealID, x.FoodID });
                    table.ForeignKey(
                        name: "FK_MealDetails_Foods",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodId");
                    table.ForeignKey(
                        name: "FK_MealDetails_Meals",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Av Hayvanları" },
                    { 2, "Balıklar" },
                    { 3, "Bitkisel Yağlar" },
                    { 4, "Çeşniler" },
                    { 5, "Çorbalar" },
                    { 6, "Deniz Ürünleri" },
                    { 7, "Diğer Besinler" },
                    { 8, "Ekmek Vb. Ürünler" },
                    { 9, "Et Ürünleri" },
                    { 10, "Hayvansal Yağlar" },
                    { 11, "İçecekler" },
                    { 12, "Kırmızı Etler" },
                    { 13, "Kurubaklagiller" },
                    { 14, "Kümes Hayvanları" },
                    { 15, "Meyveler" },
                    { 16, "Peynirler" },
                    { 17, "Sakatatlar" },
                    { 18, "Sebzeler" },
                    { 19, "Soslar" },
                    { 20, "Süt ve Ürünleri" },
                    { 21, "Şeker ve Şeker Ürünleri" },
                    { 22, "Tahıl Ürünleri" },
                    { 23, "Tatlılar" },
                    { 24, "Yumurtalar" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 1, 192.0, 0.0, 1, 12.1, "GramX100", "Bıldırcın", "..\\..\\..\\Pictures\\Bıldırcın.png", 19.600000000000001 },
                    { 2, 294.0, 0.0, 1, 23.800000000000001, "GramX100", "Güvercin", "..\\..\\..\\Pictures\\Güvercin.png", 18.5 },
                    { 3, 181.0, 0.0, 1, 9.3000000000000007, "GramX100", "Sülün", "..\\..\\..\\Pictures\\Sülün.png", 22.699999999999999 },
                    { 4, 162.0, 0.0, 1, 8.0, "GramX100", "Tavşan", "..\\..\\..\\Pictures\\Tavşan.png", 21.0 },
                    { 5, 175.0, 0.0, 2, 9.0, "GramX100", "Alabalık", "..\\..\\..\\Pictures\\Alabalık.png", 18.300000000000001 },
                    { 6, 336.0, 0.0, 2, 0.29999999999999999, "GramX100", "Balık Unu", "..\\..\\..\\Pictures\\Balık Unu.png", 78.0 },
                    { 7, 193.0, 0.0, 2, 14.4, "GramX100", "Kalkan", "..\\..\\..\\Pictures\\Kalkan.png", 148.0 },
                    { 8, 164.0, 0.0, 2, 5.5999999999999996, "GramX100", "Kılıç", "..\\..\\..\\Pictures\\Kılıç.png", 26.300000000000001 },
                    { 9, 93.0, 0.0, 2, 1.2, "GramX100", "Levrek", "..\\..\\..\\Pictures\\Levrek.png", 19.199999999999999 },
                    { 10, 96.0, 0.0, 2, 2.2999999999999998, "GramX100", "Mersin", "..\\..\\..\\Pictures\\Mersin.png", 17.699999999999999 },
                    { 11, 168.0, 0.0, 2, 7.2999999999999998, "GramX100", "Palamut", "..\\..\\..\\Pictures\\Palamut.png", 24.0 },
                    { 12, 160.0, 0.0, 2, 8.5999999999999996, "GramX100", "Sardalya", "..\\..\\..\\Pictures\\Sardalya.png", 19.199999999999999 },
                    { 13, 205.0, 0.0, 2, 11.0, "GramX100", "Sardalya (konserve)", "..\\..\\..\\Pictures\\Sardalya (konserve).png", 24.0 },
                    { 14, 155.0, 0.0, 2, 8.1999999999999993, "GramX100", "Somon", "..\\..\\..\\Pictures\\Somon.png", 20.300000000000001 },
                    { 15, 289.0, 0.0, 2, 22.0, "GramX100", "Ton", "..\\..\\..\\Pictures\\Ton.png", 22.800000000000001 },
                    { 16, 305.0, 0.0, 2, 25.100000000000001, "GramX100", "Tuzlu Balık", "..\\..\\..\\Pictures\\Tuzlu Balık.png", 18.5 },
                    { 17, 159.0, 0.0, 2, 7.2999999999999998, "GramX100", "Uskumru", "..\\..\\..\\Pictures\\Uskumru.png", 21.899999999999999 },
                    { 18, 884.0, 0.0, 3, 100.0, "GramX100", "Ayçiçeği Yağı", "..\\..\\..\\Pictures\\Ayçiçek Yağı.png", 0.0 },
                    { 19, 884.0, 0.0, 3, 100.0, "GramX100", "Fındık Yağı", "..\\..\\..\\Pictures\\Fındık Yağı.png", 0.0 },
                    { 20, 884.0, 0.0, 3, 100.0, "GramX100", "Haşhaş Yağı", "..\\..\\..\\Pictures\\Haşhaş Yağı.png", 0.0 },
                    { 21, 884.0, 0.0, 3, 100.0, "GramX100", "Keten tohumu yağı", "..\\..\\..\\Pictures\\Keten tohumu yağı.png", 0.0 },
                    { 22, 719.0, 0.90000000000000002, 3, 80.5, "GramX100", "Margarin (kahvaltılık)", "..\\..\\..\\Pictures\\Margarin.png", 0.0 },
                    { 23, 720.0, 0.0, 3, 82.0, "GramX100", "Margarin (kahvaltılık)", "..\\..\\..\\Pictures\\Margarin.png", 0.0 },
                    { 24, 884.0, 0.0, 3, 100.0, "GramX100", "Mısırözü Yağı", "..\\..\\..\\Pictures\\Mısırözü Yağı.png", 0.0 },
                    { 25, 900.0, 0.0, 3, 100.0, "GramX100", "Nebati Yağ", "..\\..\\..\\Pictures\\Nebati Yağ.png", 0.0 },
                    { 26, 884.0, 0.0, 3, 100.0, "GramX100", "Palmiye Yağı", "..\\..\\..\\Pictures\\Palmiye Yağı.png", 0.0 },
                    { 27, 884.0, 0.0, 3, 100.0, "GramX100", "Pamuk Yağı", "..\\..\\..\\Pictures\\Pamuk Yağı.png", 0.0 },
                    { 28, 884.0, 0.0, 3, 100.0, "GramX100", "Soya Yağı", "..\\..\\..\\Pictures\\Soya Yağı.png", 0.0 },
                    { 29, 884.0, 0.0, 3, 100.0, "GramX100", "Susam Yağı", "..\\..\\..\\Pictures\\Susam Yağı.png", 0.0 },
                    { 30, 884.0, 0.0, 3, 100.0, "GramX100", "Yerfıstığı Yağı", "..\\..\\..\\Pictures\\Yerfıstığı Yağı.png", 0.0 },
                    { 31, 884.0, 0.0, 3, 100.0, "GramX100", "Zeytin Yağı", "..\\..\\..\\Pictures\\Zeytin Yağı.png", 0.0 },
                    { 32, 313.0, 75.0, 4, 8.4000000000000004, "GramX100", "Defne Yaprağı", "..\\..\\..\\Pictures\\Defne Yaprağı.png", 7.5999999999999996 },
                    { 33, 253.0, 56.0, 4, 4.4000000000000004, "GramX100", "Dere Otu (Kuru)", "..\\..\\..\\Pictures\\Dereotu.png", 20.0 },
                    { 34, 469.0, 35.0, 4, 29.0, "GramX100", "Hardal (Toz)", "..\\..\\..\\Pictures\\Hardal Toz.png", 25.0 },
                    { 35, 533.0, 23.699999999999999, 4, 45.0, "GramX100", "Haşhaş Tohumu", "..\\..\\..\\Pictures\\Haşhaş Tohumu.png", 18.0 },
                    { 36, 525.0, 50.0, 4, 36.299999999999997, "GramX100", "Hindistan cevizi (Toz)", "..\\..\\..\\Pictures\\Hindistan cevizi toz.png", 6.4000000000000004 },
                    { 37, 5.0, 1.0, 4, 0.0, "DessertSpoon", "Kabartma tozu", "..\\..\\..\\Pictures\\Kabartma tozu.png", 0.0 },
                    { 38, 255.0, 65.0, 4, 3.2999999999999998, "GramX100", "Karabiber", "..\\..\\..\\Pictures\\Karabiber.png", 11.0 },
                    { 39, 323.0, 61.200000000000003, 4, 20.100000000000001, "GramX100", "Karanfil", "..\\..\\..\\Pictures\\Karanfil.png", 6.0 },
                    { 40, 276.0, 64.0, 4, 7.4000000000000004, "GramX100", "Kekik", "..\\..\\..\\Pictures\\Kekik.png", 9.0999999999999996 },
                    { 41, 318.0, 57.0, 4, 17.300000000000001, "GramX100", "Kırmızıbiber (toz)", "..\\..\\..\\Pictures\\Kırmızı Biber (toz).png", 12.0 },
                    { 42, 375.0, 44.200000000000003, 4, 22.300000000000001, "GramX100", "Kimyon (Toz)", "..\\..\\..\\Pictures\\Kimyon.png", 18.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 43, 54.0, 13.1, 4, 0.10000000000000001, "GramX100", "Kuş üzümü", "..\\..\\..\\Pictures\\Kuş üzümü.png", 1.7 },
                    { 44, 276.0, 52.0, 4, 4.4000000000000004, "GramX100", "Maydonoz (kuru)", "..\\..\\..\\Pictures\\Maydonoz.png", 22.399999999999999 },
                    { 45, 245.0, 29.800000000000001, 4, 4.9000000000000004, "GramX100", "Nane (Kuru)", "..\\..\\..\\Pictures\\Nane (Kuru).png", 15.1 },
                    { 46, 310.0, 65.0, 4, 6.5, "GramX100", "Safran", "..\\..\\..\\Pictures\\Safran.png", 11.4 },
                    { 47, 0.0, 0.0, 4, 0.0, "GramX100", "Sofra Tuzu", null, 0.0 },
                    { 48, 261.0, 80.0, 4, 3.2000000000000002, "GramX100", "Tarçın (Toz)", "..\\..\\..\\Pictures\\tarçın toz.png", 3.8999999999999999 },
                    { 49, 347.0, 71.0, 4, 6.0, "GramX100", "Zencefil", "..\\..\\..\\Pictures\\Zencefil.png", 9.0999999999999996 },
                    { 50, 354.0, 65.299999999999997, 4, 10.1, "GramX100", "Zerdecal", "..\\..\\..\\Pictures\\Zerdecal.png", 8.1999999999999993 },
                    { 51, 295.0, 50.0, 5, 1.2, "GramX100", "Bezelye", "..\\..\\..\\Pictures\\Bezelye.png", 21.0 },
                    { 52, 219.0, 45.399999999999999, 5, 1.0, "GramX100", "Domates", "..\\..\\..\\Pictures\\Domates.png", 7.0 },
                    { 53, 274.0, 51.299999999999997, 5, 1.3999999999999999, "GramX100", "Ezogelin", "..\\..\\..\\Pictures\\Ezogelin.png", 14.0 },
                    { 54, 342.0, 52.0, 5, 6.0, "GramX100", "İşkembe", "..\\..\\..\\Pictures\\işkembe.png", 20.0 },
                    { 55, 235.0, 37.5, 5, 1.0, "GramX100", "Mercimek", "..\\..\\..\\Pictures\\Mercimek.png", 19.0 },
                    { 56, 227.0, 43.200000000000003, 5, 1.1000000000000001, "GramX100", "Sebze", "..\\..\\..\\Pictures\\Sebze.png", 11.0 },
                    { 57, 290.0, 59.0, 5, 1.5, "GramX100", "Tarhana (Acı)", "..\\..\\..\\Pictures\\Tarhana.png", 12.0 },
                    { 58, 280.0, 61.0, 5, 0.40000000000000002, "GramX100", "Tarhana (tatlı)", "..\\..\\..\\Pictures\\Tarhana.png", 8.0 },
                    { 59, 252.0, 52.0, 5, 1.3, "GramX100", "Yayla", "..\\..\\..\\Pictures\\Yayla.png", 8.0 },
                    { 60, 318.0, 62.0, 5, 5.0, "GramX100", "Yulaf çorbası", "..\\..\\..\\Pictures\\Yulaf.png", 6.2999999999999998 },
                    { 61, 262.0, 3.2999999999999998, 6, 15.0, "GramX100", "Havyar", "..\\..\\..\\Pictures\\Havyar.png", 26.899999999999999 },
                    { 62, 91.0, 0.5, 6, 1.8999999999999999, "GramX100", "İstakoz", "..\\..\\..\\Pictures\\istakoz.png", 16.899999999999999 },
                    { 63, 90.0, 5.0, 6, 5.0, "Piece", "İstiridye", "..\\..\\..\\Pictures\\istiridye.png", 5.0 },
                    { 64, 91.0, 1.5, 6, 0.80000000000000004, "GramX100", "Karides", "..\\..\\..\\Pictures\\Karides.png", 18.100000000000001 },
                    { 65, 95.0, 3.2999999999999998, 6, 2.2999999999999998, "GramX100", "Midye", "..\\..\\..\\Pictures\\Midye.png", 14.1 },
                    { 66, 127.0, 0.0, 6, 5.2000000000000002, "GramX100", "Yengeç (haşlanmış)", "..\\..\\..\\Pictures\\Yengeç (haşlanmış).png", 20.100000000000001 },
                    { 67, 335.0, 0.0, 7, 0.10000000000000001, "GramX100", "Jelatin", "..\\..\\..\\Pictures\\Jelatin.png", 86.0 },
                    { 68, 299.0, 48.299999999999997, 7, 24.0, "GramX100", "Kakao", "..\\..\\..\\Pictures\\Kakao.png", 17.0 },
                    { 69, 282.0, 39.0, 7, 1.6000000000000001, "GramX100", "Maya (kuru)", "..\\..\\..\\Pictures\\Maya (kuru).png", 36.899999999999999 },
                    { 70, 86.0, 11.0, 7, 0.40000000000000002, "GramX100", "Maya (Yaş)", "..\\..\\..\\Pictures\\Maya (Yaş).png", 12.0 },
                    { 71, 12.0, 6.0, 7, 0.0, "GramX100", "Sirke", "..\\..\\..\\Pictures\\Sirke.png", 0.0 },
                    { 72, 595.0, 21.199999999999999, 7, 53.799999999999997, "GramX100", "Tahin", "..\\..\\..\\Pictures\\Tahin.png", 17.0 },
                    { 73, 10.0, 2.0, 7, 0.20000000000000001, "GramX100", "Turşu (Salatalık)", "..\\..\\..\\Pictures\\Turşu.png", 0.59999999999999998 },
                    { 74, 207.0, 1.1000000000000001, 7, 21.0, "GramX100", "Zeytin (Siyah)", "..\\..\\..\\Pictures\\Zeytin (Siyah).png", 1.8 },
                    { 75, 144.0, 2.7999999999999998, 7, 13.5, "GramX100", "Zeytin (Yeşil)", "..\\..\\..\\Pictures\\Zeytin (Yeşil).png", 1.5 },
                    { 76, 276.0, 56.399999999999999, 8, 0.80000000000000004, "GramX100", "Ekmek (buğday)", "..\\..\\..\\Pictures\\Ekmek (buğday).png", 9.0999999999999996 },
                    { 77, 243.0, 52.100000000000001, 8, 1.1000000000000001, "GramX100", "Ekmek (çavdar)", "..\\..\\..\\Pictures\\Ekmek (çavdar).png", 9.0999999999999996 },
                    { 78, 60.0, 0.0, 8, 0.0, "Slice", "Ekmek (kepek)", "..\\..\\..\\Pictures\\Ekmek (kepek).png", 0.0 },
                    { 79, 392.0, 73.400000000000006, 8, 4.5999999999999996, "GramX100", "Galeta Unu", "..\\..\\..\\Pictures\\Galeta Unu.png", 12.6 },
                    { 80, 433.0, 0.0, 8, 13.9, "GramX100", "Gramissini", "..\\..\\..\\Pictures\\Grissini.png", 12.300000000000001 },
                    { 81, 371.0, 77.0, 8, 0.90000000000000002, "GramX100", "İrmik", "..\\..\\..\\Pictures\\İrmik.png", 11.4 },
                    { 82, 479.0, 60.399999999999999, 8, 21.300000000000001, "GramX100", "Kraker (Peynirli)", "..\\..\\..\\Pictures\\Kraker (Peynirli).png", 11.199999999999999 },
                    { 83, 384.0, 73.299999999999997, 8, 9.4000000000000004, "GramX100", "Kraker (Sade)", "..\\..\\..\\Pictures\\Kraker (Sade).png", 8.0 },
                    { 84, 433.0, 71.5, 8, 12.0, "GramX100", "Kraker (tuzlu)", "..\\..\\..\\Pictures\\Kraker (Tuzlu).png", 9.8000000000000007 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 85, 369.0, 75.200000000000003, 8, 1.2, "GramX100", "Makarna", "..\\..\\..\\Pictures\\Makarna.png", 12.5 },
                    { 86, 298.0, 53.0, 8, 5.5999999999999996, "GramX100", "Sandviç ekmeği", "..\\..\\..\\Pictures\\Sandviç ekmeği.png", 8.1999999999999993 },
                    { 87, 271.0, 63.899999999999999, 8, 0.5, "GramX100", "Yufka", "..\\..\\..\\Pictures\\Yufka.png", 8.9000000000000004 },
                    { 88, 152.0, 33.0, 8, 0.29999999999999999, "GramX100", "Yufka (Böreklik)", "..\\..\\..\\Pictures\\Yufka (Böreklik).png", 3.1000000000000001 },
                    { 89, 182.0, 3.1000000000000001, 9, 10.6, "GramX100", "Jambon", "..\\..\\..\\Pictures\\Jambon.png", 17.600000000000001 },
                    { 90, 670.0, 0.20000000000000001, 9, 65.5, "GramX100", "Kavurma", "..\\..\\..\\Pictures\\Kavurma.png", 20.0 },
                    { 91, 250.0, 0.0, 9, 13.9, "GramX100", "Pastırma (çemenli)", "..\\..\\..\\Pictures\\Pastırma (çemenli).png", 29.5 },
                    { 92, 269.0, 0.0, 9, 14.9, "GramX100", "Pastırma (çemensiz)", "..\\..\\..\\Pictures\\Pastırma (çemensiz).png", 32.700000000000003 },
                    { 93, 450.0, 1.2, 9, 38.100000000000001, "GramX100", "Salam", "..\\..\\..\\Pictures\\Salam.png", 23.800000000000001 },
                    { 94, 322.0, 2.3999999999999999, 9, 29.399999999999999, "GramX100", "Sosis", "..\\..\\..\\Pictures\\Sosis.png", 11.300000000000001 },
                    { 95, 452.0, 0.0, 9, 40.799999999999997, "GramX100", "Sucuk", "..\\..\\..\\Pictures\\Sucuk.png", 21.399999999999999 },
                    { 96, 900.0, 0.0, 10, 100.0, "GramX100", "Balık Yağı", "..\\..\\..\\Pictures\\Balık Yağı.png", 0.0 },
                    { 97, 758.0, 0.0, 10, 81.799999999999997, "GramX100", "İçyağı", "..\\..\\..\\Pictures\\içyağı.png", 4.0999999999999996 },
                    { 98, 902.0, 0.0, 10, 100.0, "GramX100", "Kuyruk Yağı", "..\\..\\..\\Pictures\\Kuyruk Yağı.png", 0.0 },
                    { 99, 890.0, 0.0, 10, 98.700000000000003, "GramX100", "Sade Yağ (erimiş)", "..\\..\\..\\Pictures\\Sade Yağ.png", 0.29999999999999999 },
                    { 100, 100.0, 0.0, 10, 11.0, "DessertSpoon", "Tereyağı", "..\\..\\..\\Pictures\\Tereyağı.png", 0.0 },
                    { 101, 315.0, 60.700000000000003, 11, 12.699999999999999, "GramX100", "Adaçayı", "..\\..\\..\\Pictures\\Adaçayı.png", 10.6 },
                    { 102, 80.0, 7.0, 11, 11.0, "Goblet", "Beyaz şarap", "..\\..\\..\\Pictures\\Beyaz Şarap.png", 8.0 },
                    { 103, 150.0, 13.0, 11, 0.0, "Piece", "Bira", "..\\..\\..\\Pictures\\Bira.png", 1.0 },
                    { 104, 231.0, 0.0, 11, 0.0, "GramX100", "Cin", "..\\..\\..\\Pictures\\Cin tonic.png", 0.0 },
                    { 105, 0.0, 0.0, 11, 0.0, "Bottle", "Cola (diyet)", "..\\..\\..\\Pictures\\Cola (diyet).png", 0.0 },
                    { 106, 160.0, 41.0, 11, 0.0, "Bottle", "Cola (normal)", "..\\..\\..\\Pictures\\Cola (Normal).png", 0.0 },
                    { 107, 16.0, 3.3999999999999999, 11, 0.0, "GramX100", "Domates suyu", "..\\..\\..\\Pictures\\Domates Suyu.png", 0.69999999999999996 },
                    { 108, 39.0, 10.0, 11, 0.0, "GramX100", "Gazoz", "..\\..\\..\\Pictures\\Gazoz.png", 0.0 },
                    { 109, 42.0, 6.7000000000000002, 11, 1.3999999999999999, "GramX100", "Ihlamur", "..\\..\\..\\Pictures\\Ihlamur.png", 0.40000000000000002 },
                    { 110, 5.0, 1.0, 11, 0.0, "Cup", "Kahve (instant)", "..\\..\\..\\Pictures\\Kahve.png", 0.0 },
                    { 111, 75.0, 0.0, 11, 3.0, "Goblet", "Kırmızı şarap", "..\\..\\..\\Pictures\\Kırmızı Şarap.png", 0.0 },
                    { 112, 21.0, 5.5999999999999996, 11, 0.0, "GramX100", "Limonata", "..\\..\\..\\Pictures\\Limonata.png", 0.0 },
                    { 113, 31.0, 8.0, 11, 0.0, "GramX100", "Meyve suyu", "..\\..\\..\\Pictures\\Meyve Syuyu.png", 0.0 },
                    { 114, 45.0, 10.4, 11, 0.20000000000000001, "GramX100", "Portakal Suyu", "..\\..\\..\\Pictures\\Portakal Suyu.png", 0.69999999999999996 },
                    { 115, 71.0, 2.5, 11, 0.0, "GramX100", "Rose (şarap)", "..\\..\\..\\Pictures\\Rose (şarap).png", 0.10000000000000001 },
                    { 116, 263.0, 0.0, 11, 0.0, "GramX100", "Viski", "..\\..\\..\\Pictures\\Viski.png", 0.0 },
                    { 117, 275.0, 0.0, 11, 0.0, "GramX100", "Votka", "..\\..\\..\\Pictures\\Votka.png", 0.0 },
                    { 118, 156.0, 0.0, 12, 8.0, "GramX100", "Az yağlı dana eti", "..\\..\\..\\Pictures\\Az yağlı dana eti.png", 19.699999999999999 },
                    { 119, 472.0, 0.0, 12, 47.0, "GramX100", "Az yağlı domuz eti", "..\\..\\..\\Pictures\\Az yağlı Domuz eti.png", 11.199999999999999 },
                    { 120, 247.0, 0.0, 12, 19.399999999999999, "GramX100", "Az yağlı koyun eti", "..\\..\\..\\Pictures\\az yağlı koyun eti.png", 16.800000000000001 },
                    { 121, 225.0, 0.0, 12, 15.800000000000001, "GramX100", "Az yağlı sığır eti", "..\\..\\..\\Pictures\\Az yağlı sığır eti.png", 19.399999999999999 },
                    { 122, 145.0, 0.0, 12, 9.0, "GramX100", "Keçi eti", "..\\..\\..\\Pictures\\Keçi Eti.png", 16.0 },
                    { 123, 190.0, 0.0, 12, 12.0, "GramX100", "Orta yağlı dana eti", "..\\..\\..\\Pictures\\Orta yağlı dana eti.png", 19.100000000000001 },
                    { 124, 513.0, 0.0, 12, 52.0, "GramX100", "Orta yağlı domuz eti", "..\\..\\..\\Pictures\\Orta yağlı domuz eti.png", 10.199999999999999 },
                    { 125, 263.0, 0.0, 12, 21.300000000000001, "GramX100", "Orta yağlı koyun eti", "..\\..\\..\\Pictures\\Orta yağlı koyun eti.png", 16.5 },
                    { 126, 263.0, 0.0, 12, 20.399999999999999, "GramX100", "Orta yağlı sığır eti", "..\\..\\..\\Pictures\\Orta yağlı sığır eti.png", 18.5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 127, 223.0, 0.0, 12, 16.0, "GramX100", "Yağlı dana eti", "..\\..\\..\\Pictures\\Yağlı Dana Eti.png", 18.5 },
                    { 128, 553.0, 0.0, 12, 57.0, "GramX100", "Yağlı domuz eti", "..\\..\\..\\Pictures\\Yağlı Domuz eti.png", 9.0999999999999996 },
                    { 129, 310.0, 0.0, 12, 27.100000000000001, "GramX100", "Yağlı koyun eti", "..\\..\\..\\Pictures\\Yağlı Koyun eti.png", 15.4 },
                    { 130, 301.0, 0.0, 12, 25.0, "GramX100", "Yağlı sığır eti", "..\\..\\..\\Pictures\\Yağlı Sığır eti.png", 17.399999999999999 },
                    { 131, 560.0, 19.899999999999999, 13, 47.299999999999997, "GramX100", "Ay çekirdeği", "..\\..\\..\\Pictures\\Ay Çekirdeği.png", 24.0 },
                    { 132, 598.0, 19.0, 13, 54.200000000000003, "GramX100", "Badem", "..\\..\\..\\Pictures\\Badem.png", 18.600000000000001 },
                    { 133, 338.0, 58.200000000000003, 13, 1.7, "GramX100", "Bakla (İç)", "..\\..\\..\\Pictures\\Bakla (iç).png", 25.100000000000001 },
                    { 134, 349.0, 63.0, 13, 1.2, "GramX100", "Barbunya", "..\\..\\..\\Pictures\\Barbunya.png", 22.899999999999999 },
                    { 135, 348.0, 63.0, 13, 1.0, "GramX100", "Bezelye", "..\\..\\..\\Pictures\\Bezelye (iç).png", 24.199999999999999 },
                    { 136, 343.0, 61.700000000000003, 13, 1.5, "GramX100", "Börülce", "..\\..\\..\\Pictures\\Börülce.png", 22.800000000000001 },
                    { 137, 651.0, 15.800000000000001, 13, 64.0, "GramX100", "Ceviz", "..\\..\\..\\Pictures\\Ceviz.png", 14.800000000000001 },
                    { 138, 635.0, 20.5, 13, 60.5, "GramX100", "Çam Fıstığı", "..\\..\\..\\Pictures\\Çam fıstığı.png", 13.0 },
                    { 139, 634.0, 16.0, 13, 62.399999999999999, "GramX100", "Fındık", "..\\..\\..\\Pictures\\Fındık.png", 12.0 },
                    { 140, 560.0, 0.0, 13, 0.0, "GramX100", "Fıstık", "..\\..\\..\\Pictures\\Fıstık.png", 0.0 },
                    { 141, 340.0, 61.299999999999997, 13, 1.6000000000000001, "GramX100", "Kuru Fasulye (beyaz)", "..\\..\\..\\Pictures\\Kuru fasulye (beyaz).png", 22.300000000000001 },
                    { 142, 610.0, 16.699999999999999, 13, 50.0, "GramX100", "Kabak Çekirdeği", "..\\..\\..\\Pictures\\Kabak Çekirdeği.png", 30.0 },
                    { 143, 581.0, 19.0, 13, 45.0, "GramX100", "Kavun,Karpuz Çekirdeği", "..\\..\\..\\Pictures\\Kavun Karpuz çekirdeği.png", 25.0 },
                    { 144, 194.0, 42.100000000000001, 13, 1.5, "GramX100", "Kestane", "..\\..\\..\\Pictures\\Kestane.png", 2.8999999999999999 },
                    { 145, 131.0, 27.800000000000001, 13, 1.5, "GramX100", "Kestane Haşlanmış", "..\\..\\..\\Pictures\\kestane haşlanmış.png", 2.0 },
                    { 146, 245.0, 53.0, 13, 2.2000000000000002, "GramX100", "Kestane Kavrulmuş", "..\\..\\..\\Pictures\\Kestane kavrulmuş.png", 3.2000000000000002 },
                    { 147, 340.0, 60.100000000000001, 13, 1.1000000000000001, "GramX100", "Mercimek", "..\\..\\..\\Pictures\\Mercimek.png", 24.699999999999999 },
                    { 148, 360.0, 61.0, 13, 4.7999999999999998, "GramX100", "Nohut", "..\\..\\..\\Pictures\\Nohut.png", 20.5 },
                    { 149, 268.0, 57.799999999999997, 13, 2.6000000000000001, "GramX100", "Palamut Çekirdeği", "..\\..\\..\\Pictures\\Palamut çekirdeği.png", 3.0 },
                    { 150, 403.0, 33.5, 13, 17.699999999999999, "GramX100", "Soya Fasulyesi", "..\\..\\..\\Pictures\\Soya fasulyesi.png", 34.100000000000001 },
                    { 151, 356.0, 36.600000000000001, 13, 6.7000000000000002, "GramX100", "Soya Unu (az yağlı)", "..\\..\\..\\Pictures\\soya unu az yağlı.png", 43.399999999999999 },
                    { 152, 326.0, 38.100000000000001, 13, 0.90000000000000002, "GramX100", "Soya Unu (yağsız)", "..\\..\\..\\Pictures\\soya unu yağsız.png", 47.0 },
                    { 153, 582.0, 17.600000000000001, 13, 53.399999999999999, "GramX100", "Susam", "..\\..\\..\\Pictures\\Susam.png", 18.199999999999999 },
                    { 154, 594.0, 19.0, 13, 53.700000000000003, "GramX100", "Şam Fıstığı", "..\\..\\..\\Pictures\\Şam Fıstığı.png", 19.300000000000001 },
                    { 155, 582.0, 20.600000000000001, 13, 48.700000000000003, "GramX100", "Yer Fıstığı", "..\\..\\..\\Pictures\\Yer Fıstığı.png", 26.199999999999999 },
                    { 156, 160.0, 0.0, 14, 8.0, "GramX100", "Hindi, et ve deri", "..\\..\\..\\Pictures\\hindi et ve deri.png", 20.399999999999999 },
                    { 157, 371.0, 0.0, 14, 33.600000000000001, "GramX100", "Kaz", "..\\..\\..\\Pictures\\Kaz.png", 15.9 },
                    { 158, 404.0, 0.0, 14, 39.299999999999997, "GramX100", "Ördek", "..\\..\\..\\Pictures\\Ördek Pişmiş.png", 11.5 },
                    { 159, 75.0, 9.0, 14, 2.0, "Portion", "Şehr. tavuk çorbası", "..\\..\\..\\Pictures\\Şehr tavuk çorbası.png", 4.0 },
                    { 160, 215.0, 0.0, 14, 15.1, "GramX100", "Tavuk Whole", "..\\..\\..\\Pictures\\Tavuk Bütün.png", 18.600000000000001 },
                    { 161, 186.0, 0.0, 14, 11.1, "GramX100", "Tavuk beyaz et (derili)", "..\\..\\..\\Pictures\\Tavuk beyaz et (derili).png", 20.300000000000001 },
                    { 162, 114.0, 0.0, 14, 1.7, "GramX100", "Tavuk beyaz et (derisiz)", "..\\..\\..\\Pictures\\Tavuk beyaz et (derisiz).png", 23.199999999999999 },
                    { 163, 365.0, 13.0, 14, 18.0, "Portion", "Tavuk göğüs kızarmış", "..\\..\\..\\Pictures\\Tavuk göğüs kızarmış.png", 35.0 },
                    { 164, 125.0, 0.0, 14, 4.2999999999999998, "GramX100", "Tavuk siyah et derisiz", "..\\..\\..\\Pictures\\Tavuk siyah et derisiz.png", 20.100000000000001 },
                    { 165, 349.0, 0.0, 14, 32.399999999999999, "GramX100", "Tavuk, deri", "..\\..\\..\\Pictures\\tavuk deri.png", 13.300000000000001 },
                    { 166, 237.0, 0.0, 14, 18.300000000000001, "GramX100", "Tavuk, siyah et (derili)", "..\\..\\..\\Pictures\\tavuk siyah et derili.png", 16.699999999999999 },
                    { 167, 57.0, 13.6, 15, 0.5, "GramX100", "Ahududu (Kırmızı)", "..\\..\\..\\Pictures\\Ahududu kırmızı.png", 1.2 },
                    { 168, 73.0, 15.699999999999999, 15, 1.3999999999999999, "GramX100", "Ahududu (Siyah)", "..\\..\\..\\Pictures\\Ahududu Siyah.png", 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 169, 52.0, 13.6, 15, 0.20000000000000001, "GramX100", "Ananas", "..\\..\\..\\Pictures\\Ananas.png", 0.40000000000000002 },
                    { 170, 61.0, 15.300000000000001, 15, 0.40000000000000002, "GramX100", "Armut", "..\\..\\..\\Pictures\\Armut.png", 0.69999999999999996 },
                    { 171, 167.0, 6.2999999999999998, 15, 16.399999999999999, "GramX100", "Avokado", "..\\..\\..\\Pictures\\Avokado.png", 2.1000000000000001 },
                    { 172, 57.0, 15.300000000000001, 15, 0.10000000000000001, "GramX100", "Ayva", "..\\..\\..\\Pictures\\Ayva.png", 0.40000000000000002 },
                    { 173, 58.0, 12.9, 15, 0.90000000000000002, "GramX100", "Böğürtlen", "..\\..\\..\\Pictures\\Böğürtlen.png", 1.2 },
                    { 174, 37.0, 8.4000000000000004, 15, 0.5, "GramX100", "Çilek", "..\\..\\..\\Pictures\\Çilek.png", 0.69999999999999996 },
                    { 175, 93.0, 19.800000000000001, 15, 1.1000000000000001, "GramX100", "Dut", "..\\..\\..\\Pictures\\Dut.png", 0.90000000000000002 },
                    { 176, 58.0, 14.5, 15, 0.59999999999999998, "GramX100", "Elma", "..\\..\\..\\Pictures\\Elma.png", 0.20000000000000001 },
                    { 177, 47.0, 12.0, 15, 0.0, "GramX100", "Elma Suyu", "..\\..\\..\\Pictures\\Elma.png", 0.10000000000000001 },
                    { 178, 66.0, 17.800000000000001, 15, 0.0, "GramX100", "Erik (Kırmızı)", "..\\..\\..\\Pictures\\Erik kırmızı.png", 0.5 },
                    { 179, 79.0, 19.699999999999999, 15, 0.20000000000000001, "GramX100", "Erik (Mürdüm)", "..\\..\\..\\Pictures\\Erik mürdüm.png", 0.80000000000000004 },
                    { 180, 255.0, 67.400000000000006, 15, 0.59999999999999998, "GramX100", "Erik Mürdüm (Kuru)", "..\\..\\..\\Pictures\\Erik mürdüm kuru.png", 2.1000000000000001 },
                    { 181, 344.0, 91.299999999999997, 15, 0.5, "GramX100", "Erik Pestil", "..\\..\\..\\Pictures\\Erik pestik.png", 3.2999999999999998 },
                    { 182, 41.0, 10.6, 15, 0.10000000000000001, "GramX100", "Grameyfurt", "..\\..\\..\\Pictures\\Greyfut.png", 0.5 },
                    { 183, 39.0, 9.1999999999999993, 15, 0.10000000000000001, "GramX100", "Grameyfurt Suyu", "..\\..\\..\\Pictures\\greyfurt suyu.png", 0.5 },
                    { 184, 274.0, 72.900000000000006, 15, 0.5, "GramX100", "Hurma", "..\\..\\..\\Pictures\\Hurma.png", 2.2000000000000002 },
                    { 185, 15.0, 0.0, 15, 0.0, "Piece", "Hurma", "..\\..\\..\\Pictures\\Hurma.png", 0.0 },
                    { 186, 274.0, 69.099999999999994, 15, 1.3, "GramX100", "İncir (Kuru)", "..\\..\\..\\Pictures\\İncir Kuru.png", 4.2999999999999998 },
                    { 187, 80.0, 20.399999999999999, 15, 0.40000000000000002, "GramX100", "İncir (Taze)", "..\\..\\..\\Pictures\\İncir taze.png", 1.2 },
                    { 188, 26.0, 6.4000000000000004, 15, 0.20000000000000001, "GramX100", "Karpuz", "..\\..\\..\\Pictures\\Meyve Syuyu.png", 0.5 },
                    { 189, 33.0, 7.7000000000000002, 15, 0.29999999999999999, "GramX100", "Kavun", "..\\..\\..\\Pictures\\Meyve Syuyu.png", 0.80000000000000004 },
                    { 190, 260.0, 66.5, 15, 0.5, "GramX100", "Kayısı (Kuru)", "..\\..\\..\\Pictures\\Kayısı Pestil.png", 5.0 },
                    { 191, 17.0, 4.2999999999999998, 15, 0.10000000000000001, "Piece", "Kayısı (Taze)", "..\\..\\..\\Pictures\\Kayısı Pestil.png", 0.29999999999999999 },
                    { 192, 332.0, 84.599999999999994, 15, 1.0, "GramX100", "Kayısı Pestil", "..\\..\\..\\Pictures\\Kayısı Pestil.png", 5.5999999999999996 },
                    { 193, 5.0, 1.1000000000000001, 15, 0.10000000000000001, "Piece", "Kiraz", "..\\..\\..\\Pictures\\Kiraz.png", 0.10000000000000001 },
                    { 194, 30.0, 10.0, 15, 0.10000000000000001, "GramX100", "Kivi", "..\\..\\..\\Pictures\\Kivi.png", 0.29999999999999999 },
                    { 195, 27.0, 8.1999999999999993, 15, 0.29999999999999999, "GramX100", "Limon", "..\\..\\..\\Pictures\\Limon.png", 1.1000000000000001 },
                    { 196, 25.0, 8.0, 15, 0.20000000000000001, "GramX100", "Limon Suyu", "..\\..\\..\\Pictures\\Limon Suyu.png", 0.5 },
                    { 197, 46.0, 11.6, 15, 0.20000000000000001, "GramX100", "Mandalina", "..\\..\\..\\Pictures\\Mandalina.png", 0.80000000000000004 },
                    { 198, 43.0, 10.0, 15, 0.20000000000000001, "GramX100", "Mandalina Suyu", "..\\..\\..\\Pictures\\Mandalina suyu.png", 0.5 },
                    { 199, 105.0, 27.0, 15, 1.0, "GramX100", "Muz", "..\\..\\..\\Pictures\\Muz.png", 1.0 },
                    { 200, 63.0, 16.0, 15, 0.29999999999999999, "GramX100", "Nar", "..\\..\\..\\Pictures\\Nar.png", 0.5 },
                    { 201, 49.0, 12.199999999999999, 15, 0.20000000000000001, "GramX100", "Portakal", "..\\..\\..\\Pictures\\Portakal.png", 1.0 },
                    { 202, 38.0, 9.6999999999999993, 15, 0.10000000000000001, "GramX100", "Şeftali", "..\\..\\..\\Pictures\\Şeftali.png", 0.59999999999999998 },
                    { 203, 289.0, 77.400000000000006, 15, 0.20000000000000001, "GramX100", "Üzüm (Kuru)", "..\\..\\..\\Pictures\\Üzüm Kuru.png", 2.5 },
                    { 204, 67.0, 17.300000000000001, 15, 0.29999999999999999, "GramX100", "Üzüm (Taze)", "..\\..\\..\\Pictures\\Üzüm Taze.png", 0.59999999999999998 },
                    { 205, 66.0, 16.600000000000001, 15, 0.0, "GramX100", "Üzüm Suyu", "..\\..\\..\\Pictures\\Üzüm Suyu.png", 0.20000000000000001 },
                    { 206, 58.0, 14.300000000000001, 15, 0.29999999999999999, "GramX100", "Vişne", "..\\..\\..\\Pictures\\Vişne.png", 1.2 },
                    { 207, 235.0, 0.80000000000000004, 16, 18.199999999999999, "GramX100", "Bey. peynir (Edirne)", "..\\..\\..\\Pictures\\Bey peynir yağlı.png", 15.4 },
                    { 208, 312.0, 0.20000000000000001, 16, 26.5, "GramX100", "Bey. peynir (Urfa)", "..\\..\\..\\Pictures\\Bey peynir Urfa.png", 15.199999999999999 },
                    { 209, 289.0, 0.0, 16, 21.600000000000001, "GramX100", "Bey. peynir (yağlı)", "..\\..\\..\\Pictures\\Bey Peynir yağlı.png", 22.5 },
                    { 210, 99.0, 3.7999999999999998, 16, 0.69999999999999996, "GramX100", "Bey.peynir (yağsız)", "..\\..\\..\\Pictures\\Bey Peynir Yağsız.png", 19.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 211, 403.0, 1.3, 16, 33.100000000000001, "GramX100", "Cheddar", "..\\..\\..\\Pictures\\Cheddar.png", 24.899999999999999 },
                    { 212, 379.0, 13.800000000000001, 16, 11.699999999999999, "GramX100", "Çökelek (Kuru)", "..\\..\\..\\Pictures\\Çökelek (kuru).png", 54.899999999999999 },
                    { 213, 215.0, 3.2000000000000002, 16, 5.5999999999999996, "GramX100", "Çökelek (Taze)", "..\\..\\..\\Pictures\\Çökelek (taze).png", 35.0 },
                    { 214, 413.0, 0.40000000000000002, 16, 32.299999999999997, "GramX100", "Gramavyer (%8 Tuzlu)", "..\\..\\..\\Pictures\\Gravyer (%8 Tuzlu).png", 29.800000000000001 },
                    { 215, 357.0, 1.3999999999999999, 16, 27.800000000000001, "GramX100", "Kars Tipi", "..\\..\\..\\Pictures\\Kars Tipş.png", 25.0 },
                    { 216, 404.0, 1.3999999999999999, 16, 31.699999999999999, "GramX100", "Kaşar Peyniri", "..\\..\\..\\Pictures\\Kaşar Peyniri.png", 27.0 },
                    { 217, 349.0, 2.7000000000000002, 16, 34.899999999999999, "GramX100", "Krem Peynir (Sade)", "..\\..\\..\\Pictures\\Krem Peynir.png", 7.5999999999999996 },
                    { 218, 72.0, 2.7000000000000002, 16, 1.0, "GramX100", "Lor peyniri (%1 yağ)", "..\\..\\..\\Pictures\\Lor peyniri (%1 yağ).png", 12.4 },
                    { 219, 90.0, 3.6000000000000001, 16, 1.8999999999999999, "GramX100", "Lor peyniri (%2 yağ)", "..\\..\\..\\Pictures\\Lor peyniri(%2 yağ).png", 13.699999999999999 },
                    { 220, 85.0, 1.8999999999999999, 16, 0.40000000000000002, "GramX100", "Lor peyniri (yağsız)", "..\\..\\..\\Pictures\\Lor peyniri (yağsız).png", 17.300000000000001 },
                    { 221, 327.0, 0.5, 16, 27.300000000000001, "GramX100", "Otlu Peynir", "..\\..\\..\\Pictures\\Otlu Peynir.png", 20.100000000000001 },
                    { 222, 369.0, 2.0, 16, 30.600000000000001, "GramX100", "Rokfor", "..\\..\\..\\Pictures\\Rokfor.png", 21.5 },
                    { 223, 106.0, 0.0, 17, 3.7999999999999998, "GramX100", "Akciğer (dana)", "..\\..\\..\\Pictures\\Akciğer Dana.png", 16.800000000000001 },
                    { 224, 125.0, 0.80000000000000004, 17, 8.5999999999999996, "GramX100", "Beyin", "..\\..\\..\\Pictures\\Beyin.png", 10.4 },
                    { 225, 105.0, 0.90000000000000002, 17, 3.2999999999999998, "GramX100", "Böbrek (kuzu)", "..\\..\\..\\Pictures\\böbrek Kuzu.png", 16.800000000000001 },
                    { 226, 104.0, 0.0, 17, 3.0, "GramX100", "Dalak (sığır, dana)", "..\\..\\..\\Pictures\\Dalak sığır dana.png", 18.100000000000001 },
                    { 227, 130.0, 0.90000000000000002, 17, 5.2999999999999998, "GramX100", "Dil (dana)", "..\\..\\..\\Pictures\\Dana Dil.png", 18.5 },
                    { 228, 100.0, 0.0, 17, 2.0, "GramX100", "İşkembe (sığır)", "..\\..\\..\\Pictures\\İşkembe Sığır.png", 19.100000000000001 },
                    { 229, 140.0, 4.0999999999999996, 17, 4.7000000000000002, "GramX100", "Karaciğer (dana)", "..\\..\\..\\Pictures\\Karaciğer dana.png", 19.199999999999999 },
                    { 230, 129.0, 2.8999999999999999, 17, 3.7000000000000002, "GramX100", "Karaciğer (tavuk)", "..\\..\\..\\Pictures\\Karaciğer Tavuk.png", 19.699999999999999 },
                    { 231, 124.0, 1.8, 17, 5.9000000000000004, "GramX100", "Yürek (dana)", "..\\..\\..\\Pictures\\Yürek Dana.png", 15.0 },
                    { 232, 97.0, 15.6, 18, 1.1000000000000001, "GramX100", "Asma Yaprağı", "..\\..\\..\\Pictures\\Asma yaprağı.png", 3.7999999999999998 },
                    { 233, 266.0, 56.100000000000001, 18, 2.2000000000000002, "GramX100", "Bamya (Kurutulmuş)", "..\\..\\..\\Pictures\\bamya (kurutulmuş).png", 17.399999999999999 },
                    { 234, 36.0, 7.5999999999999996, 18, 0.29999999999999999, "GramX100", "Bamya (taze)", "..\\..\\..\\Pictures\\bamya (taze).png", 2.3999999999999999 },
                    { 235, 84.0, 14.4, 18, 0.40000000000000002, "GramX100", "Bezelye (İç)", "..\\..\\..\\Pictures\\Bezelye (iç).png", 6.2999999999999998 },
                    { 236, 88.0, 16.800000000000001, 18, 0.40000000000000002, "GramX100", "Bezelye (Konserve)", "..\\..\\..\\Pictures\\Bezelye (kONSERVE).png", 4.7000000000000002 },
                    { 237, 293.0, 64.0, 18, 2.6000000000000001, "GramX100", "Biber (Kurutulmuş)", "..\\..\\..\\Pictures\\Kırmızı Biber.png", 16.0 },
                    { 238, 22.0, 4.7999999999999998, 18, 0.20000000000000001, "GramX100", "Biber (Taze)", "..\\..\\..\\Pictures\\Biber Taze,.png", 1.2 },
                    { 239, 127.0, 21.800000000000001, 18, 0.80000000000000004, "GramX100", "Börülce (Taze)", "..\\..\\..\\Pictures\\Börülce.png", 9.0 },
                    { 240, 40.0, 8.0, 18, 1.0, "Head", "Brokoli", "..\\..\\..\\Pictures\\brokoli.png", 4.0 },
                    { 241, 25.0, 5.0, 18, 0.20000000000000001, "GramX100", "Domates (Kırmızı)", "..\\..\\..\\Pictures\\Domates (kırmızı).png", 1.0 },
                    { 242, 24.0, 5.0999999999999996, 18, 0.20000000000000001, "GramX100", "Domates (Yeşil)", "..\\..\\..\\Pictures\\Domates (yeşil).png", 1.2 },
                    { 243, 19.0, 4.2999999999999998, 18, 0.10000000000000001, "GramX100", "Domates suyu", "..\\..\\..\\Pictures\\Domates Suyu.png", 0.80000000000000004 },
                    { 244, 47.0, 4.2999999999999998, 18, 0.59999999999999998, "GramX100", "Ebegümeci", "..\\..\\..\\Pictures\\Ebegümeci.png", 4.4000000000000004 },
                    { 245, 53.0, 7.7999999999999998, 18, 0.20000000000000001, "GramX100", "Enginar", "..\\..\\..\\Pictures\\Enginar.png", 3.0 },
                    { 246, 274.0, 61.100000000000001, 18, 1.7, "GramX100", "Fasulye (Kurutulmuş)", "..\\..\\..\\Pictures\\Fasulye (kurutulmuş).png", 8.5999999999999996 },
                    { 247, 32.0, 7.0999999999999996, 18, 0.20000000000000001, "GramX100", "Fasulye (Taze)", "..\\..\\..\\Pictures\\fasulye (taze).png", 1.8999999999999999 },
                    { 248, 42.0, 9.6999999999999993, 18, 0.20000000000000001, "GramX100", "Havuç", "..\\..\\..\\Pictures\\Havuç.png", 1.1000000000000001 },
                    { 249, 15.0, 3.3999999999999999, 18, 0.10000000000000001, "GramX100", "Hıyar (Soyulmamış)", "..\\..\\..\\Pictures\\Hıyar (soyulmamış).png", 0.90000000000000002 },
                    { 250, 14.0, 3.2000000000000002, 18, 0.10000000000000001, "GramX100", "Hıyar (soyulmuş)", "..\\..\\..\\Pictures\\Hıyar (soyulmuş).png", 0.59999999999999998 },
                    { 251, 53.0, 7.0999999999999996, 18, 0.69999999999999996, "GramX100", "Hindibağ Otu", "..\\..\\..\\Pictures\\Hindibağ otu.png", 2.7000000000000002 },
                    { 252, 26.0, 4.2999999999999998, 18, 0.29999999999999999, "GramX100", "Ispanak", "..\\..\\..\\Pictures\\Ispanak.png", 3.2000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 253, 26.0, 6.5, 18, 0.10000000000000001, "GramX100", "Kabak (Kış)", "..\\..\\..\\Pictures\\Kabak (kış).png", 1.0 },
                    { 254, 19.0, 4.2000000000000002, 18, 0.10000000000000001, "GramX100", "Kabak (Yaz)", "..\\..\\..\\Pictures\\Kabak (yaz).png", 11.0 },
                    { 255, 27.0, 5.2000000000000002, 18, 0.20000000000000001, "GramX100", "Karnıbahar", "..\\..\\..\\Pictures\\Karnıbahar.png", 2.7000000000000002 },
                    { 256, 40.0, 8.5, 18, 0.29999999999999999, "GramX100", "Kereviz", "..\\..\\..\\Pictures\\Kereviz.png", 1.8 },
                    { 257, 93.0, 18.100000000000001, 18, 2.2999999999999998, "GramX100", "Kırmızı Biber (Taze)", "..\\..\\..\\Pictures\\Kırmızı Biber.png", 3.7000000000000002 },
                    { 258, 20.0, 4.0999999999999996, 18, 0.10000000000000001, "GramX100", "Kıvırcık", "..\\..\\..\\Pictures\\Kıvırcık.png", 1.7 },
                    { 259, 24.0, 5.2000000000000002, 18, 0.20000000000000001, "GramX100", "Konserve fasulye", "..\\..\\..\\Pictures\\Konserve Fasulye.png", 1.3999999999999999 },
                    { 260, 26.0, 5.0, 18, 0.20000000000000001, "GramX100", "Kuşkonmaz", "..\\..\\..\\Pictures\\Kuşkonmaz.png", 2.5 },
                    { 261, 24.0, 5.4000000000000004, 18, 0.20000000000000001, "GramX100", "Lahana (Beyaz)", "..\\..\\..\\Pictures\\lahana.png", 1.3 },
                    { 262, 63.0, 8.0, 18, 0.29999999999999999, "GramX100", "Lahana (Brüksel)", "..\\..\\..\\Pictures\\lahana brüksel.png", 5.2000000000000002 },
                    { 263, 45.0, 5.0, 18, 0.29999999999999999, "GramX100", "Lahana (Kara)", "..\\..\\..\\Pictures\\Kara Lahana.png", 4.0 },
                    { 264, 31.0, 6.9000000000000004, 18, 0.20000000000000001, "GramX100", "Lahana (Kırmızı)", "..\\..\\..\\Pictures\\Lahana Kırmızı.png", 2.0 },
                    { 265, 22.0, 0.0, 18, 0.29999999999999999, "GramX100", "Madımak", "..\\..\\..\\Pictures\\madımak.png", 2.3999999999999999 },
                    { 266, 28.0, 4.4000000000000004, 18, 0.29999999999999999, "GramX100", "Mantar", "..\\..\\..\\Pictures\\mantar.png", 2.7000000000000002 },
                    { 267, 14.0, 2.5, 18, 0.20000000000000001, "GramX100", "Marul", "..\\..\\..\\Pictures\\Marul.png", 1.2 },
                    { 268, 44.0, 8.5, 18, 0.59999999999999998, "GramX100", "Maydonoz", "..\\..\\..\\Pictures\\Maydonoz.png", 3.6000000000000001 },
                    { 269, 96.0, 22.100000000000001, 18, 1.0, "GramX100", "Mısır (Taze)", "..\\..\\..\\Pictures\\Mısır (taze).png", 3.5 },
                    { 270, 65.0, 7.9000000000000004, 18, 1.3, "GramX100", "Nane (Taze)", "..\\..\\..\\Pictures\\nane (taze).png", 4.0 },
                    { 271, 43.0, 9.9000000000000004, 18, 0.10000000000000001, "GramX100", "Pancar (Kırmızı)", "..\\..\\..\\Pictures\\Pancar Kırmızı.png", 1.6000000000000001 },
                    { 272, 24.0, 4.5999999999999996, 18, 0.29999999999999999, "GramX100", "Pancar (Yaprak)", "..\\..\\..\\Pictures\\Pancar Yaprak.png", 2.2000000000000002 },
                    { 273, 76.0, 17.100000000000001, 18, 0.10000000000000001, "GramX100", "Patates", "..\\..\\..\\Pictures\\Patates.png", 2.1000000000000001 },
                    { 274, 351.0, 80.0, 18, 0.80000000000000004, "GramX100", "Patates unu", "..\\..\\..\\Pictures\\patates unu.png", 8.0 },
                    { 275, 286.0, 49.0, 18, 2.2999999999999998, "GramX100", "Patlıcan (kurutul.)", "..\\..\\..\\Pictures\\Patlıcan Kurutulmuş.png", 13.699999999999999 },
                    { 276, 25.0, 5.5999999999999996, 18, 0.20000000000000001, "GramX100", "Patlıcan (Taze)", "..\\..\\..\\Pictures\\Patlıcan.png", 1.2 },
                    { 277, 33.0, 4.2000000000000002, 18, 0.29999999999999999, "GramX100", "Pazı", "..\\..\\..\\Pictures\\Pazı.png", 2.0 },
                    { 278, 52.0, 11.199999999999999, 18, 0.29999999999999999, "GramX100", "Pırasa", "..\\..\\..\\Pictures\\Pırasa.png", 2.2000000000000002 },
                    { 279, 33.0, 3.2000000000000002, 18, 0.59999999999999998, "GramX100", "Roka", "..\\..\\..\\Pictures\\Roka.png", 3.0 },
                    { 280, 137.0, 30.800000000000001, 18, 0.20000000000000001, "GramX100", "Sarmısak (Head)", "..\\..\\..\\Pictures\\Sarımsak Baş.png", 6.2000000000000002 },
                    { 281, 332.0, 72.700000000000003, 18, 0.80000000000000004, "GramX100", "Sarmısak (Toz)", "..\\..\\..\\Pictures\\Sarımsak Toz.png", 16.800000000000001 },
                    { 282, 32.0, 3.7999999999999998, 18, 0.40000000000000002, "GramX100", "Semiz Otu", "..\\..\\..\\Pictures\\Semizotu.png", 2.0 },
                    { 283, 38.0, 8.6999999999999993, 18, 0.10000000000000001, "GramX100", "Soğan (Kuru)", "..\\..\\..\\Pictures\\Kuru Soğan.png", 1.5 },
                    { 284, 347.0, 80.700000000000003, 18, 1.1000000000000001, "GramX100", "Soğan (Toz)", "..\\..\\..\\Pictures\\Soğan toz.png", 10.1 },
                    { 285, 36.0, 8.1999999999999993, 18, 0.20000000000000001, "GramX100", "Soğan (Yeşil)", "..\\..\\..\\Pictures\\Soğan Yeşil.png", 1.5 },
                    { 286, 30.0, 6.5999999999999996, 18, 0.20000000000000001, "GramX100", "Şalgam", "..\\..\\..\\Pictures\\Şalgam.png", 1.0 },
                    { 287, 72.0, 9.8000000000000007, 18, 0.40000000000000002, "GramX100", "Taze Bakla", "..\\..\\..\\Pictures\\Taze Bakla.png", 5.2000000000000002 },
                    { 288, 33.0, 6.0, 18, 1.0, "GramX100", "Tere", "..\\..\\..\\Pictures\\Tere.png", 3.0 },
                    { 289, 19.0, 4.2000000000000002, 18, 0.10000000000000001, "GramX100", "Turp (Kırmızı)", "..\\..\\..\\Pictures\\Turp.png", 0.90000000000000002 },
                    { 290, 30.0, 6.5999999999999996, 18, 0.20000000000000001, "GramX100", "Turp (Siyah)", "..\\..\\..\\Pictures\\Turp.png", 1.0 },
                    { 291, 75.0, 16.699999999999999, 18, 0.10000000000000001, "GramX100", "Yer Elması", "..\\..\\..\\Pictures\\Yer Elması.png", 2.2999999999999998 },
                    { 292, 49.0, 9.0, 18, 0.59999999999999998, "GramX100", "Yonca", "..\\..\\..\\Pictures\\Yonca.png", 1.0 },
                    { 293, 377.0, 15.199999999999999, 19, 35.700000000000003, "GramX100", "Bin Ada Yağı", "..\\..\\..\\Pictures\\Bin ada yağı.png", 0.90000000000000002 },
                    { 294, 430.0, 17.5, 19, 41.0, "GramX100", "Fransız salata sosu", "..\\..\\..\\Pictures\\Fransız Salata Sosu.png", 0.59999999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 295, 467.0, 10.199999999999999, 19, 48.299999999999997, "GramX100", "İtalyan salata sosu", "..\\..\\..\\Pictures\\italyan salata sosu.png", 0.69999999999999996 },
                    { 296, 106.0, 25.399999999999999, 19, 0.40000000000000002, "GramX100", "Ketçap", "..\\..\\..\\Pictures\\Ketçap.png", 2.0 },
                    { 297, 340.0, 31.0, 19, 16.0, "Glass", "Kıymalı Chili", "..\\..\\..\\Pictures\\Kıymalı Chili.png", 19.0 },
                    { 298, 134.0, 4.5999999999999996, 19, 11.699999999999999, "GramX100", "Krema (%50 yağ, süt)", "..\\..\\..\\Pictures\\Krema (yarım yağ, süt).png", 3.2000000000000002 },
                    { 299, 390.0, 23.899999999999999, 19, 33.399999999999999, "GramX100", "Mayonez", "..\\..\\..\\Pictures\\Mayonez.png", 0.90000000000000002 },
                    { 300, 449.0, 2.5, 19, 50.100000000000001, "GramX100", "Salata sosu (yağlı)", "..\\..\\..\\Pictures\\Salata Sosu (Yağlı).png", 0.0 },
                    { 301, 98.0, 21.300000000000001, 19, 0.40000000000000002, "GramX100", "Salça", "..\\..\\..\\Pictures\\Salça.png", 2.7000000000000002 },
                    { 302, 68.0, 9.5, 19, 1.3, "GramX100", "Soya Sosu", "..\\..\\..\\Pictures\\Soya Sosu.png", 5.5999999999999996 },
                    { 303, 70.0, 6.9000000000000004, 20, 4.4000000000000004, "GramX100", "Anne sütü", "..\\..\\..\\Pictures\\Manda Sütü.png", 1.0 },
                    { 304, 50.0, 4.7999999999999998, 20, 1.8999999999999999, "GramX100", "İnek (1/2 yağlı)", "..\\..\\..\\Pictures\\İnek (yarım yağlı).png", 3.2999999999999998 },
                    { 305, 61.0, 4.7000000000000002, 20, 3.2999999999999998, "GramX100", "İnek (Yağlı)", "..\\..\\..\\Pictures\\İnek Yağlı.png", 3.2999999999999998 },
                    { 306, 35.0, 4.9000000000000004, 20, 0.20000000000000001, "GramX100", "İnek (yağsız)", "..\\..\\..\\Pictures\\İnek Yağsız.png", 3.3999999999999999 },
                    { 307, 69.0, 4.5, 20, 4.0999999999999996, "GramX100", "Keçi sütü", "..\\..\\..\\Pictures\\Keçi sütü.png", 3.6000000000000001 },
                    { 308, 108.0, 5.4000000000000004, 20, 7.0, "GramX100", "Koyun", "..\\..\\..\\Pictures\\Koyun Süt.png", 6.0 },
                    { 309, 97.0, 5.2000000000000002, 20, 6.9000000000000004, "GramX100", "Manda sütü", "..\\..\\..\\Pictures\\Manda Sütü.png", 3.7999999999999998 },
                    { 310, 33.0, 2.2000000000000002, 20, 1.5, "GramX100", "Soya", "..\\..\\..\\Pictures\\Soya Sütü.png", 3.3999999999999999 },
                    { 311, 496.0, 38.399999999999999, 20, 26.699999999999999, "GramX100", "Süt Tozu (Yağlı)", "..\\..\\..\\Pictures\\Süt tozu.png", 26.300000000000001 },
                    { 312, 362.0, 52.0, 20, 0.80000000000000004, "GramX100", "Süt Tozu (Yağsız)", "..\\..\\..\\Pictures\\Süt tozu yağsız.png", 36.200000000000003 },
                    { 313, 50.0, 5.2000000000000002, 20, 1.7, "GramX100", "Yoğurt (1/2 yağlı)", "..\\..\\..\\Pictures\\Yoğurt Yarım Yağlı.png", 3.3999999999999999 },
                    { 314, 62.0, 4.9000000000000004, 20, 3.3999999999999999, "GramX100", "Yoğurt (Yağlı)", "..\\..\\..\\Pictures\\Yoğurt Yağlı.png", 3.0 },
                    { 315, 330.0, 86.900000000000006, 21, 0.0, "GramX100", "Akide şekeri", "..\\..\\..\\Pictures\\Akide şekeri.png", 0.0 },
                    { 316, 315.0, 78.400000000000006, 21, 0.0, "GramX100", "Bal", "..\\..\\..\\Pictures\\Bal.png", 0.29999999999999999 },
                    { 317, 418.0, 85.400000000000006, 21, 7.9000000000000004, "GramX100", "Bisküvi", "..\\..\\..\\Pictures\\Biskuvi.png", 6.5999999999999996 },
                    { 318, 462.0, 74.400000000000006, 21, 16.100000000000001, "GramX100", "Bisküvi (pasta)", "..\\..\\..\\Pictures\\Biskuvi pasta.png", 5.4000000000000004 },
                    { 319, 532.0, 51.299999999999997, 21, 35.600000000000001, "GramX100", "Çikolata (Bademli)", "..\\..\\..\\Pictures\\Çikolata Bademli.png", 9.3000000000000007 },
                    { 320, 543.0, 44.600000000000001, 21, 38.100000000000001, "GramX100", "Çikolata (Fıstıklı)", "..\\..\\..\\Pictures\\Çikolata Fıstıklı.png", 14.1 },
                    { 321, 528.0, 57.899999999999999, 21, 35.100000000000001, "GramX100", "Çikolata (Şekerli)", "..\\..\\..\\Pictures\\Çikolata.png", 4.4000000000000004 },
                    { 322, 477.0, 46.799999999999997, 21, 39.700000000000003, "GramX100", "Çikolata (Şekersiz)", "..\\..\\..\\Pictures\\Çikolata.png", 7.9000000000000004 },
                    { 323, 193.0, 20.800000000000001, 21, 10.6, "GramX100", "Dondurma (Sütlü)", "..\\..\\..\\Pictures\\Sütlü Dondurma.png", 4.5 },
                    { 324, 399.0, 76.599999999999994, 21, 10.199999999999999, "GramX100", "Karamela", "..\\..\\..\\Pictures\\Karemela.png", 4.0 },
                    { 325, 240.0, 57.0, 21, 1.0, "GramX100", "Lokum", "..\\..\\..\\Pictures\\Lokum.png", 0.0 },
                    { 326, 278.0, 70.799999999999997, 21, 0.29999999999999999, "GramX100", "Marmelat", "..\\..\\..\\Pictures\\Marmelat.png", 0.5 },
                    { 327, 316.0, 80.599999999999994, 21, 0.29999999999999999, "GramX100", "Meyva şekerleme", "..\\..\\..\\Pictures\\Meyva şekerleme.png", 0.40000000000000002 },
                    { 328, 293.0, 70.599999999999994, 21, 0.10000000000000001, "GramX100", "Pekmez (Üzüm)", "..\\..\\..\\Pictures\\Pekmez.png", 0.59999999999999998 },
                    { 329, 272.0, 70.0, 21, 0.10000000000000001, "GramX100", "Reçel", "..\\..\\..\\Pictures\\Reçel.png", 0.59999999999999998 },
                    { 330, 385.0, 99.5, 21, 0.0, "GramX100", "Şeker", "..\\..\\..\\Pictures\\Şeker.png", 0.0 },
                    { 331, 516.0, 53.5, 21, 28.0, "GramX100", "Tahin helvası", "..\\..\\..\\Pictures\\Tahin Helvası.png", 10.5 },
                    { 332, 349.0, 78.799999999999997, 22, 1.0, "GramX100", "Arpa", "..\\..\\..\\Pictures\\Arpa.png", 8.1999999999999993 },
                    { 333, 335.0, 72.900000000000006, 22, 2.5, "GramX100", "Buğday (aşurelik)", "..\\..\\..\\Pictures\\Buğday.png", 11.0 },
                    { 334, 332.0, 70.099999999999994, 22, 2.5, "GramX100", "Buğday (durum)", "..\\..\\..\\Pictures\\Buğday.png", 12.699999999999999 },
                    { 335, 357.0, 78.099999999999994, 22, 1.2, "GramX100", "Bulgur", "..\\..\\..\\Pictures\\Bulgur.png", 10.1 },
                    { 336, 386.0, 85.299999999999997, 22, 0.40000000000000002, "GramX100", "Corn Flakes", "..\\..\\..\\Pictures\\Cornflakes.png", 7.9000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calorie", "Carbohydrate", "CategoryId", "Fat", "MeasureType", "Name", "PicturePath", "Protein" },
                values: new object[,]
                {
                    { 337, 350.0, 74.799999999999997, 22, 1.7, "GramX100", "Çavdar Unu", "..\\..\\..\\Pictures\\Çavdar Unu.png", 3.1000000000000001 },
                    { 338, 90.0, 0.0, 22, 0.0, "Slice", "Ekmek (beyaz)", "..\\..\\..\\Pictures\\Ekmek Beyaz.png", 0.0 },
                    { 339, 365.0, 74.700000000000003, 22, 1.1000000000000001, "GramX100", "Ekmeklik", "..\\..\\..\\Pictures\\Ekmek Beyaz.png", 11.800000000000001 },
                    { 340, 213.0, 61.899999999999999, 22, 4.5999999999999996, "GramX100", "Kepek", "..\\..\\..\\Pictures\\Kepek.png", 16.0 },
                    { 341, 91.0, 21.0, 22, 1.0, "GramX100", "Mısır (haşlan.)", "..\\..\\..\\Pictures\\Haşlanmış mısır.png", 3.2999999999999998 },
                    { 342, 368.0, 76.900000000000006, 22, 2.6000000000000001, "GramX100", "Mısır unu", "..\\..\\..\\Pictures\\Mısır Unu.png", 7.7999999999999998 },
                    { 343, 362.0, 72.099999999999994, 22, 4.7000000000000002, "GramX100", "Mısır, tane", "..\\..\\..\\Pictures\\Mısır tane.png", 11.9 },
                    { 344, 362.0, 87.599999999999994, 22, 0.0, "GramX100", "Nişasta", "..\\..\\..\\Pictures\\Mısır Nişasta.png", 0.29999999999999999 },
                    { 345, 456.0, 59.100000000000001, 22, 21.800000000000001, "GramX100", "Patlamış mısır", "..\\..\\..\\Pictures\\Patlamış Mısır.png", 9.8000000000000007 },
                    { 346, 363.0, 80.400000000000006, 22, 0.40000000000000002, "GramX100", "Pirinç", "..\\..\\..\\Pictures\\Pirinç.png", 6.7000000000000002 },
                    { 347, 388.0, 72.0, 22, 4.5999999999999996, "GramX100", "Şehriye", "..\\..\\..\\Pictures\\Şehriye.png", 12.800000000000001 },
                    { 348, 316.0, 56.399999999999999, 22, 4.4000000000000004, "GramX100", "Tarhana", "..\\..\\..\\Pictures\\Tarhana2.png", 12.199999999999999 },
                    { 349, 388.0, 68.0, 22, 75.0, "GramX100", "Yulaf Unu", "..\\..\\..\\Pictures\\Yulaf Unu.png", 12.0 },
                    { 350, 280.0, 26.0, 23, 18.0, "Slice", "Cheesecake", "..\\..\\..\\Pictures\\CheeseCake.png", 5.0 },
                    { 351, 3350.0, 317.0, 23, 213.0, "Whole", "Cheesecake", "..\\..\\..\\Pictures\\CheeseCake.png", 60.0 },
                    { 352, 45.0, 7.0, 23, 2.0, "Piece", "Çikolatalı kurabiye", "..\\..\\..\\Pictures\\Çikolatalı Kurabiye.png", 0.5 },
                    { 353, 405.0, 60.0, 23, 18.0, "Slice", "Elmalı turta", "..\\..\\..\\Pictures\\Elmalı Turta.png", 3.0 },
                    { 354, 2420.0, 360.0, 23, 105.0, "Whole", "Elmalı turta", "..\\..\\..\\Pictures\\Elmalı turta.png", 21.0 },
                    { 355, 211.0, 33.200000000000003, 23, 7.5999999999999996, "GramX100", "Hanımgöbeği", "..\\..\\..\\Pictures\\Hanımgöbeği.png", 2.3999999999999999 },
                    { 356, 6175.0, 775.0, 23, 328.0, "Whole", "Havuçlu kek", "..\\..\\..\\Pictures\\Havuçlu Kek.png", 63.0 },
                    { 357, 385.0, 48.0, 23, 21.0, "Slice", "Havuçlu kek", "..\\..\\..\\Pictures\\Havuçlu Kek.png", 4.0 },
                    { 358, 318.0, 59.399999999999999, 23, 7.0999999999999996, "GramX100", "Hurma tatlısı", "..\\..\\..\\Pictures\\Hurma Tatlısı.png", 4.0999999999999996 },
                    { 359, 302.0, 43.600000000000001, 23, 12.5, "GramX100", "İrmik helvası", "..\\..\\..\\Pictures\\İrmik helvası.png", 3.7999999999999998 },
                    { 360, 259.0, 62.5, 23, 0.0, "GramX100", "Jöle", "..\\..\\..\\Pictures\\Jole.png", 6.0999999999999996 },
                    { 361, 126.0, 16.100000000000001, 23, 5.2000000000000002, "GramX100", "Kastırd", "", 5.9000000000000004 },
                    { 362, 364.0, 79.400000000000006, 23, 0.80000000000000004, "GramX100", "Kek pasta", "..\\..\\..\\Pictures\\Kek Pasta.png", 7.5 },
                    { 363, 173.0, 29.699999999999999, 23, 3.7999999999999998, "GramX100", "Muhallebi", "..\\..\\..\\Pictures\\Muhallebi.png", 5.0999999999999996 },
                    { 364, 139.0, 38.0, 23, 2.7000000000000002, "GramX100", "Sütlaç", "..\\..\\..\\Pictures\\Sütlaç.png", 3.3999999999999999 },
                    { 365, 286.0, 46.700000000000003, 23, 9.0999999999999996, "GramX100", "Tel kadayıf (fıstıklı)", "..\\..\\..\\Pictures\\Tel Kadayıf.png", 4.2999999999999998 },
                    { 366, 535.0, 62.5, 23, 21.899999999999999, "GramX100", "Wafers", "", 4.7000000000000002 },
                    { 367, 158.0, 0.40000000000000002, 24, 11.1, "GramX100", "Bıldırcın yumurta", "..\\..\\..\\Pictures\\Bıldırcın Yumurtası.png", 13.1 },
                    { 368, 185.0, 1.3999999999999999, 24, 13.300000000000001, "GramX100", "Kaz yumurta", "..\\..\\..\\Pictures\\Kaz Yumurta.png", 13.9 },
                    { 369, 185.0, 1.5, 24, 13.800000000000001, "GramX100", "Ördek yumurta", "..\\..\\..\\Pictures\\Ördek Yumurta.png", 12.800000000000001 },
                    { 370, 49.0, 1.2, 24, 0.0, "GramX100", "Tavuk yumurta (beyaz)", "..\\..\\..\\Pictures\\Tavuk Yumurta (Beyaz).png", 10.1 },
                    { 371, 369.0, 0.20000000000000001, 24, 32.899999999999999, "GramX100", "Tavuk yumurta (sarı)", "..\\..\\..\\Pictures\\Tavuk Yumurta (Sarı).png", 16.399999999999999 },
                    { 372, 158.0, 1.2, 24, 11.199999999999999, "GramX100", "Tavuk yumurta (tam)", "..\\..\\..\\Pictures\\Tavuk Yumurta (Tam).png", 12.1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetails_FoodID",
                table: "MealDetails",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CustomerId",
                table: "Meals",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealDetails");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
