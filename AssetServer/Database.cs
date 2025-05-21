using AssetServer.models;

namespace AssetServer
{
    public class Database
    {
        public List<Category> categories = new List<Category>()
        {
            new Category {
                id= "fbfdc484-954e-42af-9355-77d30ba20f4c",
                icon= "null.png",
                gender= "",
                name= "Body",
                username= "body",
                parentCategoryId= ""
            },
            new Category {
                id= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00",
                icon= "null.png",
                gender= "male",
                name= "Head",
                username= "head_male",
                parentCategoryId= ""
            },
            new Category {
                id= "f787d639-2837-49f6-9a7c-528d12f3e041",
                icon= "null.png",
                gender= "female",
                name= "Head",
                username= "head_female",
                parentCategoryId= ""
            },
            new Category {
                id= "b0dcd5c3-45b5-4806-a417-d30aee8498d3",
                icon= "null.png",
                gender= "male",
                name= "Wearable",
                username= "wearable_male",
                parentCategoryId= ""
            },
            new Category {
                id= "09dd4cd3-02ec-4a25-b766-b82ba371e33e",
                icon= "null.png",
                gender= "female",
                name= "Wearable",
                username= "wearable_female",
                parentCategoryId= ""
            },
            new Category {
                id= "152cf972-ca86-4788-b574-3c609ba374f8",
                icon= "body.png",
                gender= "",
                name= "Body",
                username= "body_body",
                parentCategoryId= "fbfdc484-954e-42af-9355-77d30ba20f4c"
            },
            new Category {
                id= "9f47709d-0605-4273-b1d5-b0e313328275",
                icon= "Face.png",
                gender= "male",
                name= "Jaw",
                username= "male_jaw",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "d6c0376d-a47d-4ce9-95b5-f0b913c22f26",
                icon= "eyes.png",
                gender= "male",
                name= "Eye",
                username= "male_eye",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "f3790e1f-e3ad-45e2-9a80-63cd1103a588",
                icon= "eyebrow.png",
                gender= "male",
                name= "Eyebrow",
                username= "male_eyebrow",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7",
                icon= "nose.png",
                gender= "male",
                name= "Nose",
                username= "male_nose",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "40a64b1e-3dee-4dcf-8edb-1c27f272273f",
                icon= "lips.png",
                gender= "male",
                name= "Lip",
                username= "male_lip",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "a48570e4-22f3-4859-9699-db237b4efe60",
                icon= "ear.png",
                gender= "male",
                name= "Ear",
                username= "male_ear",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "a4d378dd-b183-4b07-b313-1148497ad24f",
                icon= "hair.png",
                gender= "male",
                name= "Hair",
                username= "male_hair",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "71338736-6f1b-4a19-ab25-60b60f2cef33",
                icon= "Beard.png",
                gender= "male",
                name= "Beard",
                username= "male_beard",
                parentCategoryId= "5aca8d01-15c6-4b6d-b0d5-f5b1e4296f00"
            },
            new Category {
                id= "474422c6-84b9-46f2-9007-24d9981f9cbe",
                icon= "Face.png",
                gender= "female",
                name= "Jaw",
                username= "female_jaw",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "7ca9b427-8f70-4457-bd11-33c907ba3b84",
                icon= "eyes.png",
                gender= "female",
                name= "Eye",
                username= "female_eye",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "2975c1db-8fdb-4302-b5c2-49a3197bfd55",
                icon= "eyebrow.png",
                gender= "female",
                name= "Eyebrow",
                username= "female_eyebrow",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "a5ead37b-6320-4c68-848a-34eb82f3237a",
                icon= "nose.png",
                gender= "female",
                name= "Nose",
                username= "female_nose",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f",
                icon= "lips.png",
                gender= "female",
                name= "Lip",
                username= "female_lip",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "04648161-d32f-4a88-be8f-5ec590458a63",
                icon= "ear.png",
                gender= "female",
                name= "Ear",
                username= "female_ear",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "b689e714-51f4-4bdf-af0c-50406c06ecc7",
                icon= "hair.png",
                gender= "female",
                name= "Hair",
                username= "female_hair",
                parentCategoryId= "f787d639-2837-49f6-9a7c-528d12f3e041"
            },
            new Category {
                id= "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e",
                icon= "shirt.png",
                gender= "male",
                name= "Top",
                username= "male_top",
                parentCategoryId= "b0dcd5c3-45b5-4806-a417-d30aee8498d3"
            },
            new Category {
                id= "eb5a518f-3ddd-4110-a7fe-74085bdc99d7",
                icon= "pants.png",
                gender= "male",
                name= "Bottom",
                username= "male_bottom",
                parentCategoryId= "b0dcd5c3-45b5-4806-a417-d30aee8498d3"
            },
            new Category {
                id= "97c5e2c4-a346-426c-846e-9f53432043fb",
                icon= "shoes.png",
                gender= "male",
                name= "Shoes",
                username= "male_shoe",
                parentCategoryId= "b0dcd5c3-45b5-4806-a417-d30aee8498d3"
            },
            new Category {
                id= "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f",
                icon= "shirt.png",
                gender= "female",
                name= "Top",
                username= "female_top",
                parentCategoryId= "09dd4cd3-02ec-4a25-b766-b82ba371e33e"
            },
            new Category {
                id= "3e0b47c5-125e-43cf-a0fc-d1d73516004e",
                icon= "pants.png",
                gender= "female",
                name= "Bottom",
                username= "female_bottom",
                parentCategoryId= "09dd4cd3-02ec-4a25-b766-b82ba371e33e"
            },
            new Category {
                id= "776135bc-5ca0-4775-b006-39e74f8f1d64",
                icon= "shoes.png",
                gender= "female",
                name= "Shoes",
                username= "female_shoe",
                parentCategoryId= "09dd4cd3-02ec-4a25-b766-b82ba371e33e"
            }
        };










        public List<Asset> assets = new List<Asset>()
        {
            new Asset{
                icon = "Boy.png",
                file = "Male_Body.glb",
                gender = "male",
                name = "Male",
                username = "male_body",
                type = "file",
                data = "",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "Girl.png",
                file = "Female_Body.glb",
                gender = "female",
                name = "Female",
                username = "female_body",
                type = "file",
                data = "",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "non_binary.png",
                file = "",
                gender = "",
                name = "NonBinary",
                username = "",
                type = "",
                data = "",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "Frame-1_2.png",
                file = "",
                gender = "",
                name = "Slim",
                username = "slim_body",
                type = "data",
                data = "{\"blendshape\" : {\"Fat\" = 0, \"Thin\" = 100}}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "body.png",
                file = "",
                gender = "",
                name = "Normal",
                username = "normal_body",
                type = "data",
                data = "{\"blendshape\" : {\"Fat\" = 0, \"Thin\" = 0}}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "Frame-1_1.png",
                file = "",
                gender = "",
                name = "Fat",
                username = "fat_body",
                type = "data",
                data = "{\"blendshape\" : {\"Fat\" = 100, \"Thin\" = 0}}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin1.png",
                file = "Male01.jpg,Male01Face.jpg",
                gender = "male",
                name = "Skin1",
                username = "male_skin1",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male01.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male01Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin2.png",
                file = "Male02.jpg,Male02Face.jpg",
                gender = "male",
                name = "Skin2",
                username = "male_skin2",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male02.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male02Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin3.png",
                file = "Male03.jpg,Male03Face.jpg",
                gender = "male",
                name = "Skin3",
                username = "male_skin3",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male03.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male03Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin4.png",
                file = "Male04.jpg,Male04Face.jpg",
                gender = "male",
                name = "Skin4",
                username = "male_skin4",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male04.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male04Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin5.png",
                file = "Male05.jpg,Male05Face.jpg",
                gender = "male",
                name = "Skin5",
                username = "male_skin5",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male05.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male05Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin6.png",
                file = "Male06.jpg,Male06Face.jpg",
                gender = "male",
                name = "Skin6",
                username = "male_skin6",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male06.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male06Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin7.png",
                file = "Male07.jpg,Male07Face.jpg",
                gender = "male",
                name = "Skin7",
                username = "male_skin7",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male07.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male07Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin8.png",
                file = "Male08.jpg,Male08Face.jpg",
                gender = "male",
                name = "Skin8",
                username = "male_skin8",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male08.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male08Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin9.png",
                file = "Male09.jpg,Male09Face.jpg",
                gender = "male",
                name = "Skin9",
                username = "male_skin9",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male09.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male09Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin10.png",
                file = "Male10.jpg,Male10Face.jpg",
                gender = "male",
                name = "Skin10",
                username = "male_skin10",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male10.jpg\",\"material_name\":\"Body_Male\"},{\"file\":\"Male10Face.jpg\",\"material_name\":\"Head_Male\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin1.png",
                file = "Female01.jpg,Female01Face.jpg",
                gender = "female",
                name = "Skin1",
                username = "female_skin1",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female01.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female01Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin2.png",
                file = "Female02.jpg,Female02Face.jpg",
                gender = "female",
                name = "Skin2",
                username = "female_skin2",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female02.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female02Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin3.png",
                file = "Female03.jpg,Female03Face.jpg",
                gender = "female",
                name = "Skin3",
                username = "female_skin3",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female03.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female03Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin4.png",
                file = "Female04.jpg,Female04Face.jpg",
                gender = "female",
                name = "Skin4",
                username = "female_skin4",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female04.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female04Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin5.png",
                file = "Female05.jpg,Female05Face.jpg",
                gender = "female",
                name = "Skin5",
                username = "female_skin5",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female05.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female05Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin6.png",
                file = "Female06.jpg,Female06Face.jpg",
                gender = "female",
                name = "Skin6",
                username = "female_skin6",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female06.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female06Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin7.png",
                file = "Female07.jpg,Female07Face.jpg",
                gender = "female",
                name = "Skin7",
                username = "female_skin7",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female07.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female07Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin8.png",
                file = "Female08.jpg,Female08Face.jpg",
                gender = "female",
                name = "Skin8",
                username = "female_skin8",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female08.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female08Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin9.png",
                file = "Female09.jpg,Female09Face.jpg",
                gender = "female",
                name = "Skin9",
                username = "female_skin9",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female09.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female09Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "skin10.png",
                file = "Female10.jpg,Female10Face.jpg",
                gender = "female",
                name = "Skin10",
                username = "female_skin10",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female10.jpg\",\"material_name\":\"Body_Female\"},{\"file\":\"Female10Face.jpg\",\"material_name\":\"Head_Female\"}]}",
                categoryId = "152cf972-ca86-4788-b574-3c609ba374f8"
            },
            new Asset{
                icon = "Male_Jaw_0.png",
                file = "",
                gender = "male",
                name = "Jaw1",
                username = "jaw1",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 0, \"Jaw_2\" = 0}}",
                categoryId = "9f47709d-0605-4273-b1d5-b0e313328275"
            },
            new Asset{
                icon = "Male_Jaw_1.png",
                file = "",
                gender = "male",
                name = "Jaw2",
                username = "jaw2",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 100, \"Jaw_2\" = 0}}",
                categoryId = "9f47709d-0605-4273-b1d5-b0e313328275"
            },
            new Asset{
                icon = "Male_Jaw_2.png",
                file = "",
                gender = "male",
                name = "Jaw3",
                username = "jaw3",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 0, \"Jaw_2\" = 100}}",
                categoryId = "9f47709d-0605-4273-b1d5-b0e313328275"
            },
            new Asset{
                icon = "Male_Jaw_3_100_100.png",
                file = "",
                gender = "male",
                name = "Jaw4",
                username = "jaw4",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 100, \"Jaw_2\" = 100}}",
                categoryId = "9f47709d-0605-4273-b1d5-b0e313328275"
            },
            new Asset{
                icon = "Male_Jaw_4_50_50.png",
                file = "",
                gender = "male",
                name = "Jaw5",
                username = "jaw5",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 50, \"Jaw_2\" = 50}}",
                categoryId = "9f47709d-0605-4273-b1d5-b0e313328275"
            },
            new Asset{
                icon = "Male_Eyes_0.png",
                file = "",
                gender = "male",
                name = "Eye1",
                username = "eye1",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 0}}",
                categoryId = "d6c0376d-a47d-4ce9-95b5-f0b913c22f26"
            },
            new Asset{
                icon = "Male_Eyes_1.png",
                file = "",
                gender = "male",
                name = "Eye2",
                username = "eye2",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 100, \"Eyes_2\" = 0}}",
                categoryId = "d6c0376d-a47d-4ce9-95b5-f0b913c22f26"
            },
            new Asset{
                icon = "Male_Eyes_2.png",
                file = "",
                gender = "male",
                name = "Eye3",
                username = "eye3",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 100}}",
                categoryId = "d6c0376d-a47d-4ce9-95b5-f0b913c22f26"
            },
            new Asset{
                icon = "Male_Eyes_3_50_50.png",
                file = "",
                gender = "male",
                name = "Eye4",
                username = "eye4",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 50, \"Eyes_2\" = 50}}",
                categoryId = "d6c0376d-a47d-4ce9-95b5-f0b913c22f26"
            },
            new Asset{
                icon = "Male_Eyes_4_0_50.png",
                file = "",
                gender = "male",
                name = "Eye5",
                username = "eye5",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 50}}",
                categoryId = "d6c0376d-a47d-4ce9-95b5-f0b913c22f26"
            },
            new Asset{
                icon = "Male_Eyebrow_1.png",
                file = "Male_Eyebrow_Hairscalp_Mask_1.png",
                gender = "male",
                name = "Eyebrow1",
                username = "eyebrow1",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Eyebrow_Hairscalp_Mask_1.png\",\"material_name\":\"Hairscalp a Eyebrows a Beard_male\"}]}",
                categoryId = "f3790e1f-e3ad-45e2-9a80-63cd1103a588"
            },
            new Asset{
                icon = "Male_Eyebrow_2.png",
                file = "Male_Eyebrow_Hairscalp_Mask_2.png",
                gender = "male",
                name = "Eyebrow2",
                username = "eyebrow2",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Eyebrow_Hairscalp_Mask_2.png\",\"material_name\":\"Hairscalp a Eyebrows a Beard_male\"}]}",
                categoryId = "f3790e1f-e3ad-45e2-9a80-63cd1103a588"
            },
            new Asset{
                icon = "Male_Eyebrow_3.png",
                file = "Male_Eyebrow_Hairscalp_Mask_3.png",
                gender = "male",
                name = "Eyebrow3",
                username = "eyebrow3",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Eyebrow_Hairscalp_Mask_3.png\",\"material_name\":\"Hairscalp a Eyebrows a Beard_male\"}]}",
                categoryId = "f3790e1f-e3ad-45e2-9a80-63cd1103a588"
            },
            new Asset{
                icon = "Male_Nose_0.png",
                file = "",
                gender = "male",
                name = "Nose1",
                username = "nose1",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 0, \"Nose_2\" = 0}}",
                categoryId = "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7"
            },
            new Asset{
                icon = "Male_Nose_1.png",
                file = "",
                gender = "male",
                name = "Nose2",
                username = "nose2",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 100, \"Nose_2\" = 0}}",
                categoryId = "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7"
            },
            new Asset{
                icon = "Male_Nose_2.png",
                file = "",
                gender = "male",
                name = "Nose3",
                username = "nose3",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 0, \"Nose_2\" = 100}}",
                categoryId = "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7"
            },
            new Asset{
                icon = "Male_Nose_3_50_50.png",
                file = "",
                gender = "male",
                name = "Nose4",
                username = "nose4",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 50, \"Nose_2\" = 50}}",
                categoryId = "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7"
            },
            new Asset{
                icon = "Male_Nose_4_100_100.png",
                file = "",
                gender = "male",
                name = "Nose5",
                username = "nose5",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 100, \"Nose_2\" = 100}}",
                categoryId = "6f2cb8da-3e62-4d17-83d2-2f9cdb9bb9d7"
            },
            new Asset{
                icon = "Male_Lips_0.png",
                file = "",
                gender = "male",
                name = "Lip1",
                username = "lip1",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 0, \"Lips_2\" = 0}}",
                categoryId = "40a64b1e-3dee-4dcf-8edb-1c27f272273f"
            },
            new Asset{
                icon = "Male_Lips_1.png",
                file = "",
                gender = "male",
                name = "Lip2",
                username = "lip2",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 100, \"Lips_2\" = 0}}",
                categoryId = "40a64b1e-3dee-4dcf-8edb-1c27f272273f"
            },
            new Asset{
                icon = "Male_Lips_2.png",
                file = "",
                gender = "male",
                name = "Lip3",
                username = "lip3",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 0, \"Lips_2\" = 100}}",
                categoryId = "40a64b1e-3dee-4dcf-8edb-1c27f272273f"
            },
            new Asset{
                icon = "Male_Lips_3_100_100.png",
                file = "",
                gender = "male",
                name = "Lip4",
                username = "lip4",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 100, \"Lips_2\" = 100}}",
                categoryId = "40a64b1e-3dee-4dcf-8edb-1c27f272273f"
            },
            new Asset{
                icon = "Male_Lips_4_25_25.png",
                file = "",
                gender = "male",
                name = "Lip5",
                username = "lip5",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 25, \"Lips_2\" = 25}}",
                categoryId = "40a64b1e-3dee-4dcf-8edb-1c27f272273f"
            },
            new Asset{
                icon = "Male_Ear_0.png",
                file = "",
                gender = "male",
                name = "Ear1",
                username = "ear1",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 0, \"Ear_2\" = 0}}",
                categoryId = "a48570e4-22f3-4859-9699-db237b4efe60"
            },
            new Asset{
                icon = "Male_Ear_1.png",
                file = "",
                gender = "male",
                name = "Ear2",
                username = "ear2",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 100, \"Ear_2\" = 0}}",
                categoryId = "a48570e4-22f3-4859-9699-db237b4efe60"
            },
            new Asset{
                icon = "Male_Ear_2.png",
                file = "",
                gender = "male",
                name = "Ear3",
                username = "ear3",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 0, \"Ear_2\" = 100}}",
                categoryId = "a48570e4-22f3-4859-9699-db237b4efe60"
            },
            new Asset{
                icon = "Male_Ear_3_50_50.png",
                file = "",
                gender = "male",
                name = "Ear4",
                username = "ear4",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 50, \"Ear_2\" = 50}}",
                categoryId = "a48570e4-22f3-4859-9699-db237b4efe60"
            },
            new Asset{
                icon = "Male_Ear_4_100_100.png",
                file = "",
                gender = "male",
                name = "Ear5",
                username = "ear5",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 100, \"Ear_2\" = 100}}",
                categoryId = "a48570e4-22f3-4859-9699-db237b4efe60"
            },
            new Asset{
                icon = "MH1_Icon.png",
                file = "MH1.glb",
                gender = "male",
                name = "Hair1",
                username = "hair1",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "MH2_Icon.png",
                file = "MH2.glb",
                gender = "male",
                name = "Hair2",
                username = "hair2",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "MH3_Icon.png",
                file = "MH3.glb",
                gender = "male",
                name = "Hair3",
                username = "hair3",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "MH4_Icon.png",
                file = "MH4.glb",
                gender = "male",
                name = "Hair4",
                username = "hair4",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "MH5_Icon.png",
                file = "MH5.glb",
                gender = "male",
                name = "Hair5",
                username = "hair5",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "MH6_Icon.png",
                file = "MH6.glb",
                gender = "male",
                name = "Hair6",
                username = "hair6",
                type = "file",
                data = "",
                categoryId = "a4d378dd-b183-4b07-b313-1148497ad24f"
            },
            new Asset{
                icon = "Male_Beard_1.png",
                file = "Male_Beard_Mask_1.png",
                gender = "male",
                name = "Beard1",
                username = "beard1",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Beard_Mask_1.png\",\"material_name\":\"Beard_male 1\"}]}",
                categoryId = "71338736-6f1b-4a19-ab25-60b60f2cef33"
            },
            new Asset{
                icon = "Male_Beard_2.png",
                file = "Male_Beard_Mask_2.png",
                gender = "male",
                name = "Beard2",
                username = "beard2",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Beard_Mask_2.png\",\"material_name\":\"Beard_male 1\"}]}",
                categoryId = "71338736-6f1b-4a19-ab25-60b60f2cef33"
            },
            new Asset{
                icon = "Male_Beard_3.png",
                file = "Male_Beard_Mask_3.png",
                gender = "male",
                name = "Beard3",
                username = "beard3",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Male_Beard_Mask_3.png\",\"material_name\":\"Beard_male 1\"}]}",
                categoryId = "71338736-6f1b-4a19-ab25-60b60f2cef33"
            },
            new Asset{
                icon = "MT1_Icon.png",
                file = "MT1.glb",
                gender = "male",
                name = "Top1",
                username = "top1",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT2_Icon.png",
                file = "MT2.glb",
                gender = "male",
                name = "Top2",
                username = "top2",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT3_Icon.png",
                file = "MT3.glb",
                gender = "male",
                name = "Top3",
                username = "top3",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT4_Icon.png",
                file = "MT4.glb",
                gender = "male",
                name = "Top4",
                username = "top4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT5_Icon.png",
                file = "MT5.glb",
                gender = "male",
                name = "Top5",
                username = "top5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT6_Icon.png",
                file = "MT6.glb",
                gender = "male",
                name = "Top6",
                username = "top6",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT7_Icon.png",
                file = "MT7.glb",
                gender = "male",
                name = "Top7",
                username = "top7",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT8_Icon.png",
                file = "MT8.glb",
                gender = "male",
                name = "Top8",
                username = "top8",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT9_Icon.png",
                file = "MT9.glb",
                gender = "male",
                name = "Top9",
                username = "top9",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MT10_Icon.png",
                file = "MT10.glb",
                gender = "male",
                name = "Top10",
                username = "top10",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Chest_LOD0\",\"Male_Body_LOD0\",\"Male_Arms_LOD0\",\"Male_Arms_Upper_LOD0\",\"Male_Elbows_LOD0\",\"Male_Wrists_LOD0\"]}",
                categoryId = "cc22bdae-d5d6-4173-9517-1cbf97a1bf9e"
            },
            new Asset{
                icon = "MB1_Icon.png",
                file = "MB1.glb",
                gender = "male",
                name = "Bottom1",
                username = "bottom1",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB2_Icon.png",
                file = "MB2.glb",
                gender = "male",
                name = "Bottom2",
                username = "bottom2",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB3_Icon.png",
                file = "MB3.glb",
                gender = "male",
                name = "Bottom3",
                username = "bottom3",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB4_Icon.png",
                file = "MB4.glb",
                gender = "male",
                name = "Bottom4",
                username = "bottom4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB5_Icon.png",
                file = "MB5.glb",
                gender = "male",
                name = "Bottom5",
                username = "bottom5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB6_Icon.png",
                file = "MB6.glb",
                gender = "male",
                name = "Bottom6",
                username = "bottom6",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB7_Icon.png",
                file = "MB7.glb",
                gender = "male",
                name = "Bottom7",
                username = "bottom7",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB8_Icon.png",
                file = "MB8.glb",
                gender = "male",
                name = "Bottom8",
                username = "bottom8",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MB9_Icon.png",
                file = "MB9.glb",
                gender = "male",
                name = "Bottom9",
                username = "bottom9",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Hips_LOD0\",\"Male_Thighes_LOD0\",\"Male_Legs_Upper_LOD0\",\"Male_Knees_LOD0\",\"Male_Legs_Lower_LOD0\"]}",
                categoryId = "eb5a518f-3ddd-4110-a7fe-74085bdc99d7"
            },
            new Asset{
                icon = "MS1_Icon.png",
                file = "MS1.glb",
                gender = "male",
                name = "Shoes1",
                username = "shoes1",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS2_Icon.png",
                file = "MS2.glb",
                gender = "male",
                name = "Shoes2",
                username = "shoes2",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS3_Icon.png",
                file = "MS3.glb",
                gender = "male",
                name = "Shoes3",
                username = "shoes3",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS4_Icon.png",
                file = "MS4.glb",
                gender = "male",
                name = "Shoes4",
                username = "shoes4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS5_Icon.png",
                file = "MS5.glb",
                gender = "male",
                name = "Shoes5",
                username = "shoes5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS6_Icon.png",
                file = "MS6.glb",
                gender = "male",
                name = "Shoes6",
                username = "shoes6",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "MS7_Icon.png",
                file = "MS7.glb",
                gender = "male",
                name = "Shoes7",
                username = "shoes7",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Male_Foots Fingers_LOD0\"]}",
                categoryId = "97c5e2c4-a346-426c-846e-9f53432043fb"
            },
            new Asset{
                icon = "Female_Jaw_0.png",
                file = "",
                gender = "female",
                name = "Jaw1",
                username = "jaw1",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 0, \"Jaw_2\" = 0}}",
                categoryId = "474422c6-84b9-46f2-9007-24d9981f9cbe"
            },
            new Asset{
                icon = "Female_Jaw_1.png",
                file = "",
                gender = "female",
                name = "Jaw2",
                username = "jaw2",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 100, \"Jaw_2\" = 0}}",
                categoryId = "474422c6-84b9-46f2-9007-24d9981f9cbe"
            },
            new Asset{
                icon = "Female_Jaw_2.png",
                file = "",
                gender = "female",
                name = "Jaw3",
                username = "jaw3",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 0, \"Jaw_2\" = 100}}",
                categoryId = "474422c6-84b9-46f2-9007-24d9981f9cbe"
            },
            new Asset{
                icon = "Female_Jaw_3_100_100.png",
                file = "",
                gender = "female",
                name = "Jaw4",
                username = "jaw4",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 100, \"Jaw_2\" = 100}}",
                categoryId = "474422c6-84b9-46f2-9007-24d9981f9cbe"
            },
            new Asset{
                icon = "Female_Jaw_4_50_50.png",
                file = "",
                gender = "female",
                name = "Jaw5",
                username = "jaw5",
                type = "data",
                data = "{\"blendshape\" : {\"Jaw_1\" = 50, \"Jaw_2\" = 50}}",
                categoryId = "474422c6-84b9-46f2-9007-24d9981f9cbe"
            },
            new Asset{
                icon = "Female_Eyes_0.png",
                file = "",
                gender = "female",
                name = "Eye1",
                username = "eye1",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 0}}",
                categoryId = "7ca9b427-8f70-4457-bd11-33c907ba3b84"
            },
            new Asset{
                icon = "Female_Eyes_1.png",
                file = "",
                gender = "female",
                name = "Eye2",
                username = "eye2",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 100, \"Eyes_2\" = 0}}",
                categoryId = "7ca9b427-8f70-4457-bd11-33c907ba3b84"
            },
            new Asset{
                icon = "Female_Eyes_2.png",
                file = "",
                gender = "female",
                name = "Eye3",
                username = "eye3",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 100}}",
                categoryId = "7ca9b427-8f70-4457-bd11-33c907ba3b84"
            },
            new Asset{
                icon = "Female_Eyes_3_50_100.png",
                file = "",
                gender = "female",
                name = "Eye4",
                username = "eye4",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 50, \"Eyes_2\" = 50}}",
                categoryId = "7ca9b427-8f70-4457-bd11-33c907ba3b84"
            },
            new Asset{
                icon = "Female_Eyes_4_0_50.png",
                file = "",
                gender = "female",
                name = "Eye5",
                username = "eye5",
                type = "data",
                data = "{\"blendshape\" : {\"Eyes_1\" = 0, \"Eyes_2\" = 50}}",
                categoryId = "7ca9b427-8f70-4457-bd11-33c907ba3b84"
            },
            new Asset{
                icon = "Female_Eyebrow_1.png",
                file = "Female_HairScalp_Eyebrow1_Mask.png",
                gender = "female",
                name = "Eyebrow1",
                username = "eyebrow1",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female_HairScalp_Eyebrow1_Mask.png\",\"material_name\":\"Hairscalp a Eyebrows 1_Female\"}]}",
                categoryId = "2975c1db-8fdb-4302-b5c2-49a3197bfd55"
            },
            new Asset{
                icon = "Female_Eyebrow_2.png",
                file = "Female_HairScalp_Eyebrow2_Mask.png",
                gender = "female",
                name = "Eyebrow2",
                username = "eyebrow2",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female_HairScalp_Eyebrow2_Mask.png\",\"material_name\":\"Hairscalp a Eyebrows 1_Female\"}]}",
                categoryId = "2975c1db-8fdb-4302-b5c2-49a3197bfd55"
            },
            new Asset{
                icon = "Female_Eyebrow_3.png",
                file = "Female_HairScalp_Eyebrow3_Mask.png",
                gender = "female",
                name = "Eyebrow3",
                username = "eyebrow3",
                type = "Textures",
                data = "{\"textures\" :[{\"file\":\"Female_HairScalp_Eyebrow1_Mask.png\",\"material_name\":\"Hairscalp a Eyebrows 1_Female\"}]}",
                categoryId = "2975c1db-8fdb-4302-b5c2-49a3197bfd55"
            },
            new Asset{
                icon = "Female_Nose_0.png",
                file = "",
                gender = "female",
                name = "Nose1",
                username = "nose1",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 0, \"Nose_2\" = 0}}",
                categoryId = "a5ead37b-6320-4c68-848a-34eb82f3237a"
            },
            new Asset{
                icon = "Female_Nose_1.png",
                file = "",
                gender = "female",
                name = "Nose2",
                username = "nose2",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 100, \"Nose_2\" = 0}}",
                categoryId = "a5ead37b-6320-4c68-848a-34eb82f3237a"
            },
            new Asset{
                icon = "Female_Nose_2.png",
                file = "",
                gender = "female",
                name = "Nose3",
                username = "nose3",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 0, \"Nose_2\" = 100}}",
                categoryId = "a5ead37b-6320-4c68-848a-34eb82f3237a"
            },
            new Asset{
                icon = "Female_Nose_3_50_50.png",
                file = "",
                gender = "female",
                name = "Nose4",
                username = "nose4",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 50, \"Nose_2\" = 50}}",
                categoryId = "a5ead37b-6320-4c68-848a-34eb82f3237a"
            },
            new Asset{
                icon = "Female_Nose_4_100_100.png",
                file = "",
                gender = "female",
                name = "Nose5",
                username = "nose5",
                type = "data",
                data = "{\"blendshape\" : {\"Nose_1\" = 100, \"Nose_2\" = 100}}",
                categoryId = "a5ead37b-6320-4c68-848a-34eb82f3237a"
            },
            new Asset{
                icon = "Female_Lips_0.png",
                file = "",
                gender = "female",
                name = "Lip1",
                username = "lip1",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 0, \"Lips_2\" = 0}}",
                categoryId = "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f"
            },
            new Asset{
                icon = "Female_Lips_1.png",
                file = "",
                gender = "female",
                name = "Lip2",
                username = "lip2",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 100, \"Lips_2\" = 0}}",
                categoryId = "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f"
            },
            new Asset{
                icon = "Female_Lips_2.png",
                file = "",
                gender = "female",
                name = "Lip3",
                username = "lip3",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 0, \"Lips_2\" = 100}}",
                categoryId = "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f"
            },
            new Asset{
                icon = "Female_Lips_3_100_100.png",
                file = "",
                gender = "female",
                name = "Lip4",
                username = "lip4",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 100, \"Lips_2\" = 100}}",
                categoryId = "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f"
            },
            new Asset{
                icon = "Female_Lips_4_25_25.png",
                file = "",
                gender = "female",
                name = "Lip5",
                username = "lip5",
                type = "data",
                data = "{\"blendshape\" : {\"Lips_1\" = 25, \"Lips_2\" = 25}}",
                categoryId = "4a0602cf-d6f2-4bcd-88b8-410f901e8e9f"
            },
            new Asset{
                icon = "Female_Ear_0.png",
                file = "",
                gender = "female",
                name = "Ear1",
                username = "ear1",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 0, \"Ear_2\" = 0}}",
                categoryId = "04648161-d32f-4a88-be8f-5ec590458a63"
            },
            new Asset{
                icon = "Female_Ear_1.png",
                file = "",
                gender = "female",
                name = "Ear2",
                username = "ear2",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 100, \"Ear_2\" = 0}}",
                categoryId = "04648161-d32f-4a88-be8f-5ec590458a63"
            },
            new Asset{
                icon = "Female_Ear_2.png",
                file = "",
                gender = "female",
                name = "Ear3",
                username = "ear3",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 0, \"Ear_2\" = 100}}",
                categoryId = "04648161-d32f-4a88-be8f-5ec590458a63"
            },
            new Asset{
                icon = "Female_Ear_3_50_50.png",
                file = "",
                gender = "female",
                name = "Ear4",
                username = "ear4",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 50, \"Ear_2\" = 50}}",
                categoryId = "04648161-d32f-4a88-be8f-5ec590458a63"
            },
            new Asset{
                icon = "Female_Ear_4_100_100.png",
                file = "",
                gender = "female",
                name = "Ear5",
                username = "ear5",
                type = "data",
                data = "{\"blendshape\" : {\"Ear_1\" = 100, \"Ear_2\" = 100}}",
                categoryId = "04648161-d32f-4a88-be8f-5ec590458a63"
            },
            new Asset{
                icon = "FH1_Icon.png",
                file = "FH1.glb",
                gender = "female",
                name = "Hair1",
                username = "hair1",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FH2_Icon.png",
                file = "FH2.glb",
                gender = "female",
                name = "Hair2",
                username = "hair2",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FH3_Icon.png",
                file = "FH3.glb",
                gender = "female",
                name = "Hair3",
                username = "hair3",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FH4_Icon.png",
                file = "FH4.glb",
                gender = "female",
                name = "Hair4",
                username = "hair4",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FH5_Icon.png",
                file = "FH5.glb",
                gender = "female",
                name = "Hair5",
                username = "hair5",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FH6_Icon.png",
                file = "FH6.glb",
                gender = "female",
                name = "Hair6",
                username = "hair6",
                type = "file",
                data = "",
                categoryId = "b689e714-51f4-4bdf-af0c-50406c06ecc7"
            },
            new Asset{
                icon = "FT1_Icon.png",
                file = "FT1.glb",
                gender = "female",
                name = "Top1",
                username = "top1",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Belly_LOD0\", \"Female_Breasts_LOD0\", \"Female_Chest_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT2_Icon.png",
                file = "FT2.glb",
                gender = "female",
                name = "Top2",
                username = "top2",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Belly_LOD0\", \"Female_Breasts_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT3_Icon.png",
                file = "FT3.glb",
                gender = "female",
                name = "Top3",
                username = "top3",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Belly_LOD0\", \"Female_Breasts_LOD0\", \"Female_Chest_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT4_Icon.png",
                file = "FT4.glb",
                gender = "female",
                name = "Top4",
                username = "top4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Breasts_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT5_Icon.png",
                file = "FT5.glb",
                gender = "female",
                name = "Top5",
                username = "top5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Breasts_LOD0\", \"Female_Chest_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT6_Icon.png",
                file = "FT6.glb",
                gender = "female",
                name = "Top6",
                username = "top6",
                type = "file",
                data = "{\"disable_body_parts\" : [ \"Female_Breasts_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT7_Icon.png",
                file = "FT7.glb",
                gender = "female",
                name = "Top7",
                username = "top7",
                type = "file",
                data = "{\"disable_body_parts\" : [ \"Female_Breasts_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT8_Icon.png",
                file = "FT8.glb",
                gender = "female",
                name = "Top8",
                username = "top8",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Breasts_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT9_Icon.png",
                file = "FT9.glb",
                gender = "female",
                name = "Top9",
                username = "top9",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Breasts_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT10_Icon.png",
                file = "FT10.glb",
                gender = "female",
                name = "Top10",
                username = "top10",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Chest_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT11_Icon.png",
                file = "FT11.glb",
                gender = "female",
                name = "Top11",
                username = "top11",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Breasts_LOD0\", \"Female_Chest_LOD0\", \"Female_Elbows_LOD0\", \"Female_Hips_LOD0\", \"Female_Shoulder_LOD0\", \"Female_Thighes_LOD0\", \"Female_Wrists_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FT12_Icon.png",
                file = "FT12.glb",
                gender = "female",
                name = "Top12",
                username = "top12",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Arms_LOD0\", \"Female_Arms_Upper_LOD0\", \"Female_Hips_LOD0\", \"Female_Thighes_LOD0\"]}",
                categoryId = "f94f6ac1-6304-4e5d-969a-4d7006c9fe9f"
            },
            new Asset{
                icon = "FB1_Icon.png",
                file = "FB1.glb",
                gender = "female",
                name = "Bottom1",
                username = "bottom1",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB2_Icon.png",
                file = "FB2.glb",
                gender = "female",
                name = "Bottom2",
                username = "bottom2",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB3_Icon.png",
                file = "FB3.glb",
                gender = "female",
                name = "Bottom3",
                username = "bottom3",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\",\"Female_Knees_LOD0\",\"Female_Legs_Lower_LOD0\",\"Female_Legs_Upper_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB4_Icon.png",
                file = "FB4.glb",
                gender = "female",
                name = "Bottom4",
                username = "bottom4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB5_Icon.png",
                file = "FB5.glb",
                gender = "female",
                name = "Bottom5",
                username = "bottom5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB6_Icon.png",
                file = "FB6.glb",
                gender = "female",
                name = "Bottom6",
                username = "bottom6",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\",\"Female_Knees_LOD0\",\"Female_Legs_Lower_LOD0\",\"Female_Legs_Upper_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB7_Icon.png",
                file = "FB7.glb",
                gender = "female",
                name = "Bottom7",
                username = "bottom7",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\",\"Female_Knees_LOD0\",\"Female_Legs_Lower_LOD0\",\"Female_Legs_Upper_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FB8_Icon.png",
                file = "FB8.glb",
                gender = "female",
                name = "Bottom8",
                username = "bottom8",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Hips_LOD0\",\"Female_Thighes_LOD0\"]}",
                categoryId = "3e0b47c5-125e-43cf-a0fc-d1d73516004e"
            },
            new Asset{
                icon = "FS1_Icon.png",
                file = "FS1.glb",
                gender = "female",
                name = "Shoes1",
                username = "shoes1",
                type = "file",
                data = "",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            //new Asset{
            //    icon = "FS2_Icon.png",
            //    file = "FS2.glb",
            //    gender = "female",
            //    name = "Shoes2",
            //    username = "shoes2",
            //    type = "file",
            //    data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
            //    categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            //},
            //new Asset{
            //    icon = "FS3_Icon.png",
            //    file = "FS3.glb",
            //    gender = "female",
            //    name = "Shoes3",
            //    username = "shoes3",
            //    type = "file",
            //    data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
            //    categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            //},
            new Asset{
                icon = "FS4_Icon.png",
                file = "FS4.glb",
                gender = "female",
                name = "Shoes4",
                username = "shoes4",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            new Asset{
                icon = "FS5_Icon.png",
                file = "FS5.glb",
                gender = "female",
                name = "Shoes5",
                username = "shoes5",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            new Asset{
                icon = "FS6_Icon.png",
                file = "FS6.glb",
                gender = "female",
                name = "Shoes6",
                username = "shoes6",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            new Asset{
                icon = "FS7_Icon.png",
                file = "FS7.glb",
                gender = "female",
                name = "Shoes7",
                username = "shoes7",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            new Asset{
                icon = "FS8_Icon.png",
                file = "FS8.glb",
                gender = "female",
                name = "Shoes8",
                username = "shoes8",
                type = "file",
                data = "{\"disable_body_parts\" : [\"Female_Foots Fingers_LOD0\"]}",
                categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            },
            //new Asset{
            //    icon = "FS9_Icon.png",
            //    file = "FS9.glb",
            //    gender = "female",
            //    name = "Shoes9",
            //    username = "shoes9",
            //    type = "file",
            //    data = "",
            //    categoryId = "776135bc-5ca0-4775-b006-39e74f8f1d64"
            //}
        };
    }
}
