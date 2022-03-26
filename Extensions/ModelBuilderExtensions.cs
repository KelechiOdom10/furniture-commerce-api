using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Sofas", Description = "Sink into a little slice of heaven. Our modern sofas and sleepers are here to satisfy your seating senses. Available in sumptuous leather, soft velvet and a variety of other fabrics to complete your living room ensemble.", ImageUrl = "https://images.unsplash.com/photo-1555041469-a586c61ea9bc", Slug = "sofas", CreatedAt = DateTime.Now.AddYears(-1) },
            new Category { Id = 2, Name = "Kitchen", Description = "Best kitchenware and accessories with functionality and a modern style.", ImageUrl = "https://images.unsplash.com/photo-1610701596061-2ecf227e85b2", Slug = "kitchen", CreatedAt = DateTime.Now.AddDays(-10).AddYears(-1) },
            new Category { Id = 3, Name = "Beds", Description = "Whether beautifully upholstered or baring their elegant wood frames to the world, our modern beds are so good-looking you’ll want to leave the lights on.", ImageUrl = "https://images.unsplash.com/photo-1618773928121-c32242e63f39", Slug = "beds", CreatedAt = DateTime.Now.AddDays(-5).AddYears(-1) },
            new Category { Id = 4, Name = "Lighting", Description = "Quality lighting that evokes emotion.", ImageUrl = "https://images.unsplash.com/photo-1524484485831-a92ffc0de03f", Slug = "lighting", CreatedAt = DateTime.Now.AddDays(-3).AddYears(-1) },
            new Category
            {
                Id = 5,
                Name = "Office",
                Description = "Keep home office morale high. Whether you’re conferencing for eight or working at a power desk for one, we’ve got you covered.",
                ImageUrl = "https://images.unsplash.com/photo-1533090161767-e6ffed986c88",
                Slug = "office",
                CreatedAt = DateTime.Now.AddDays(-2).AddYears(-1)
            });

        modelBuilder.Entity<ProductType>().HasData(
            new ProductType
            {
                Id = 1,
                Name = "Corner Sofas",
                ImageUrl = "https://i.pinimg.com/originals/46/8c/0a/468c0abf669104e862355303efc1b6e7.png",
                Slug = "corner-sofas",
                CategoryId = 1,
                CreatedAt = DateTime.Now.AddDays(-200)
            },
            new ProductType
            {
                Id = 2,
                Name = "3 Seater Sofas",
                ImageUrl = "https://images.dfs.co.uk/i/dfs/mya_3a_simplywoollook_steelgrey_view1?$dfs_v2_pdp_m$&fmt=auto",
                Slug = "3-seater-sofas",
                CategoryId = 1,
                CreatedAt = DateTime.Now.AddDays(-100)
            },
            new ProductType
            {
                Id = 3,
                Name = "Modular Sofas",
                ImageUrl = "https://www.lapalma.it/uploads/product/thumbnail/135/collection_webp_plus_classic_trasparente.png.webp",
                Slug = "modular-sofas",
                CategoryId = 1,
                CreatedAt = DateTime.Now.AddDays(-250)
            },
            new ProductType
            {
                Id = 4,
                Name = "Cookware",
                ImageUrl = "https://www.lecreuset.co.uk/dw/image/v2/BDSR_PRD/on/demandware.static/-/Sites-master-catalog-LC/default/dwda0e17d9/images/hires/Full_HD_PNG/LC_20190624_ZS_PS_FS_51804000010002_001.png?sw=765&sh=575&sm=fit",
                Slug = "cookware",
                CategoryId = 2,
                CreatedAt = DateTime.Now.AddDays(-150)
            },
            new ProductType
            {
                Id = 5,
                Name = "Kitchen Accessories",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0526/4261/1399/products/1.png?v=1628686245",
                Slug = "kitchen-accessories",
                CategoryId = 2,
                CreatedAt = DateTime.Now.AddDays(-200)
            },
            new ProductType
            {
                Id = 6,
                Name = "Tableware",
                ImageUrl = "http://cdn.ecommercedns.uk/files/4/228904/0/13183260/9120001338-0.png",
                Slug = "tableware",
                CategoryId = 2,
                CreatedAt = DateTime.Now.AddDays(-100)
            },
            new ProductType
            {
                Id = 7,
                Name = "Double Beds",
                ImageUrl = "https://www.bedsofparadise.co.uk/a-bespoke-client-folders/paradise/bespoke-images/product/carnival-double-bed-frame-3727",
                Slug = "double-beds",
                CategoryId = 3,
                CreatedAt = DateTime.Now.AddDays(-250)
            },
            new ProductType
            {
                Id = 8,
                Name = "Single Beds",
                ImageUrl = "https://www.afs-admin.co.uk/images-product/rialto-light-grey-linen-bed-90cm-78246",
                Slug = "single-beds",
                CategoryId = 3,
                CreatedAt = DateTime.Now.AddDays(-150)
            },
            new ProductType
            {
                Id = 9,
                Name = "King Size Beds",
                ImageUrl = "https://www.bedsofparadise.co.uk/a-bespoke-client-folders/paradise/bespoke-images/product/Bern%20Frame%20Grey.png",
                Slug = "king-size-beds",
                CategoryId = 3,
                CreatedAt = DateTime.Now.AddDays(-180)
            },
            new ProductType
            {
                Id = 10,
                Name = "Floor Lamps",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0251/5529/products/206100313_01copy_360x.png?v=1623766088",
                Slug = "floor-lamps",
                CategoryId = 4,
                CreatedAt = DateTime.Now.AddDays(-80)
            },
            new ProductType
            {
                Id = 11,
                Name = "Wall Lights",
                ImageUrl = "https://res.cloudinary.com/clippings/image/upload/t_small_square/dpr_auto,f_auto,w_auto/v2/products/brooklyn-wall-light-with-tube-glass-brass-holder-brass-ring-tube-glass-industville-clippings-11324159.png",
                Slug = "wall-lights",
                CategoryId = 4,
                CreatedAt = DateTime.Now.AddDays(-90)
            },
            new ProductType
            {
                Id = 12,
                Name = "Ceiling Lights",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0342/2425/products/UMAGE_packshot_2329_AsteriaUp_pearlwhite__3_4df81b09-4b79-4bdb-892b-7c5121e4c6fd_600x.png?v=1636450893",
                Slug = "ceiling-lights",
                CategoryId = 4,
                CreatedAt = DateTime.Now.AddDays(-120)
            },
            new ProductType
            {
                Id = 13,
                Name = "Office Chairs",
                ImageUrl = "https://northdecoshop.com/5910-large_default/office-chair-low-leather.jpg",
                Slug = "office-chairs",
                CategoryId = 5,
                CreatedAt = DateTime.Now.AddDays(-330)
            },
            new ProductType
            {
                Id = 14,
                Name = "Office Desks",
                ImageUrl = "https://cdn11.bigcommerce.com/s-a9q2mnae4u/images/stencil/1280x1280/products/987/1466/91e9720027c98bffd301fe0e816dc3e16f774a68__69715.1646422397.png?c=1&imbypass=on",
                Slug = "office-desks",
                CategoryId = 5,
                CreatedAt = DateTime.Now.AddDays(-300)
            });


        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Harlow",
                Price = 1150,
                Title = "Left Hand Facing Chaise End Corner Sofa, Mountain Grey",
                Description = "Perfect for lazy days, Harlow's large proportions and plump cushions make relaxing easy. There's two loose side cushions too – prop them where feels best.",
                ProductTypeId = 1,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/9/2/8/d/928d311ecc71f85f815d9e0d638d34815b4e333f_SOFHLW001GRY_UK_Harlow_Left_Hand_Facing_Chaise_End_Corner_Sofa_Mountain_Grey_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/9/e/8/29e80347e4bdc078b03e426a5acfcf81939b545f_SOFHLW001GRY_UK_Harlow_Left_Hand_Facing_Chaise_End_Corner_Sofa_Mountain_Grey_ar3_2_LB02_LS.jpg" },
                Quantity = 20,
                Slug = "harlow-left-hand-facing-chaise-end-corner-sofa-mountain-grey",
                CreatedAt = DateTime.Now.AddDays(-60)
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Amicie",
                Price = 925,
                Title = "Right Hand Facing Chaise End Corner Sofa, Dark Anthracite Recycled Velvet",
                Description = "Upholstered in velvet with a charming channelled backrest, Amicie's square frame gives a fresh, contemporary feel to that mid-century influence. This chaise end corner sofa's big enough to spread out – or snuggle up. Amicie's a real showstopper, at a great price, too.",
                ProductTypeId = 1,
                Images = new string[] {"https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/d/b/1/b/db1b0b971f8838b697e3b00191742cbcb06b5f86_SOFAMI052GRY_UK_Amicie_Right_Hand_Facing_Chaise_End_Corner_Sofa_Dark_Anthracite_Velvet_ar3_2_LB.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/e/4/0/ce400ec4b0e6d88df719e6d19039ad93565a71fb_SOFAMI052GRY_UK_Amicie_Right_Hand_Facing_Chaise_End_Corner_Sofa_Dark_Anthracite_Velvet_ar3_2_LB.jpg","https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/3/1/2/9/31298ca58f0490775fa8df69f807d2876dbac533_SOFAMI052GRY_UK_Amicie_Right_Hand_Facing_Chaise_End_Corner_Sofa_Dark_Anthracite_Velvet_ar3_2_LB."
                },
                Quantity = 6,
                Slug = "amicie-right-hand-facing-chaise-end-corner-sofa-dark-anthracite-recycled-velvet",
                CreatedAt = DateTime.Now.AddDays(-30)
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Scott",
                Price = 1250,
                Title = "3 Seater Sofa,Petrol Cotton Velvet",
                Description = "Nothing says luxury quite like Scott. A sleek silhouette with pulled detail cushions, upholstered in plush velvet – it oozes sophistication. The clean lines nod to mid-century design, and there’s plenty of room to snuggle up.",
                ProductTypeId = 2,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/4/2/3/b4230880125806c26c488923a5db9543e37f7764_SOFSCT028GRY_UK_Scott_3_Seater_Sofa_Petrol_Cotton_Velvet_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/e/1/9/9/e199d0946b2526606fb80bd7f02bc96a41a09a2f_SOFSCT028GRY_UK_Scott_3_Seater_Sofa_Petrol_Cotton_Velvet_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/4/5/a/d/45ad5b38009354f6b67badeff944dc84b44e79b2_SOFSCT028GRY_UK_Scott_3_Seater_Sofa_Petrol_Cotton_Velvet_ar3_2_LB04_PS.png" },
                Quantity = 8,
                Slug = "scott-3-seater-sofa-petrol-cotton-velvet",
                CreatedAt = DateTime.Now.AddDays(-55)
            },
            new Product
            {
                Id = 4,
                CategoryId = 1,
                Name = "Mogen",
                Price = 679,
                Title = "3 Seater Sofa Bed, Steel Boucle",
                Description = "Mogen's got it all – for all spaces. Plush, comfy seating that transforms into an equally comfortable bed for guests. Thick, chunky arms. Loose, soft back cushions. Prepare for arguments over who gets to sleep here.",
                ProductTypeId = 2,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_1.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/9/6/e/f96e3b25b9b191fed8e4ed10e9d7f8b1230fa65c_SOFMOG018GRY_UK_Mogen_3_Seater_Sofa_Bed_Steel_Boucle_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_1.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/0/0/7/2/00725b88c7494e46bf8c02db2cbd77a80710609c_SOFMOG018GRY_UK_Mogen_3_Seater_Sofa_Bed_Steel_Boucle_ar3_2_LB02_LS.jpg" },
                Quantity = 4,
                Slug = "mogen-3-seater-sofa-bed-steel-boucle",
                CreatedAt = DateTime.Now.AddDays(-68)
            },
            new Product
            {
                Id = 5,
                CategoryId = 1,
                Name = "Trent",
                Price = 2395,
                Title = "Loose Cover Corner Sofa, Washed Grey Cotton Fabric",
                Description = "Trent’s deep seats are as relaxing and comfy as they look. And it comes with bolster cushions, making curling up on this corner sofa a little more tempting. Even better? It’s fitted with loose covers, which means washing's a doddle.",
                ProductTypeId = 3,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_1.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/1/1/ca114fa0135d4418ca99912b8206caebfc5cace6_CHATNT009GRY_UK_Trent_Loose_Cover_Corner_Sofa_Washed_Grey_Cotton_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/1/5/ca157ff3a9f63adfa93d791fad2d33f32fde31ce_CHATNT009GRY_UK_Trent_Loose_Cover_Corner_Sofa_Washed_Grey_Cotton_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/d/f/9/bdf96a4da119e0ad8965b38e5d4b5a7b5d9aa4b3_CHATNT009GRY_UK_Trent_Loose_Cover_Corner_Sofa_Washed_Grey_Cotton_ar3_2_LB04_PS.png" },
                Quantity = 3,
                Slug = "trent-loose-cover-corner-sofa-washed-grey-cotton-fabric",
                CreatedAt = DateTime.Now.AddDays(-75)
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Kasey",
                Price = 55,
                Title = "Set of 2 Mini Presentation Pans, Stainless Steel",
                Description = "What's better than a set of 2 presentation saucepans? Mini versions. And that's where Nicolas Vahé's Kasey comes in. Perfect for serving food from hob to table, they're made from stainless steel with rustic brass handles. Obsessed? So are we.",
                ProductTypeId = 4,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/9/f/1/5/9f15cc2a7c0d35358ab55bc696e5011c9cc69c25_MWHKAS001SIL_UK_Kasey_S2_Mini_Presentation_Pans_Silver_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/0/4/d/2/04d2c1008335e3fe5dfbfdffe1b7ffeec936fd87_MWHKAS001SIL_UK_Kasey_S2_Mini_Presentation_Pans_Silver_ar3_2_LB04_DT.png" },
                Quantity = 12,
                Slug = "kasey-set-of-2-mini-presentation-pans-stainless-steel",
                CreatedAt = DateTime.Now.AddDays(-80)
            },
            new Product
            {
                Id = 7,
                CategoryId = 2,
                Name = "Colter",
                Price = 110,
                Title = "Soft Close Double Recycling Pedal Bin, 2 x 30L, Midnight Navy",
                Description = "Colter's industrial tone lets you bring style to every corner of your kitchen. In a navy powder-coated metal, this pedal bin contains two 30L sections, ideal for splitting up your recycling. Doing your bit for the planet, and looking good too.",
                ProductTypeId = 5,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/7/1/1/5711497d45fea79f142b43abdf4926098f914bf0_BTACOL008NAV_UK_Colter_60L_Soft_Close_Double_Recycling_Pedal_Bin_x2_30L_Midnight_Navy_ar3_2_LB0.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/a/2/c/c/a2cc4dd61b3506b564bb971ff4e311bd8b91f5ab_BTACOL008NAV_UK_Colter_60L_Soft_Close_Double_Recycling_Pedal_Bin_x2_30L_Midnight_Navy_ar3_2_LB0.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/e/3/b/b/e3bb3af9af172ada3a69910c3072a2ba6981ec80_BTACOL008NAV_UK_Colter_60L_Soft_Close_Double_Recycling_Pedal_Bin_x2_30L_Midnight_Navy_ar3_2_LB0.png" },
                Quantity = 4,
                Slug = "colter-soft-close-double-recycling-pedal-bin-2-x-30l-midnight-navy",
                CreatedAt = DateTime.Now.AddDays(-45)
            },
            new Product
            {
                Id = 8,
                CategoryId = 2,
                Name = "Kendra",
                Price = 29,
                Title = "Oil & Vinegar Bottle, Grey Speckled Stoneware",
                Description = "What's speckled, stoneware and brimming with Nordic style? Bloomingville’s Kendra. We love the organic shape and timeless design of this bottle. Each one is unique which makes it extra special. And there’s more to enjoy from this collection, too.",
                ProductTypeId = 6,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/a/4/f/ba4f54fdad96e521e4cd66b619741f23c1ad7caa_MWHKEN018GRY_UK_Kendra_Speckle_Oil_Vinegar_Grey_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/3/3/a/5/33a56aac56461615633ff112ddc3758b950d6035_MWHKEN018GRY_UK_Kendra_Speckle_Oil_Vinegar_Grey_ar3_2_LB04_DT.png" },
                Quantity = 4,
                Slug = "kendra-oil-vinegar-bottle-grey-speckled-stoneware",
                CreatedAt = DateTime.Now.AddDays(-40)
            },
            new Product
            {
                Id = 9,
                CategoryId = 3,
                Name = "Roscoe",
                Price = 495,
                Title = "Double Bed, Salcombe Beige & Dark Stain Oak Legs",
                Description = "Roscoe's perfect for breathing new life into your bedroom. Clean lines and walnut legs hint at Nordic charm, while the fresh fabric ups the luxe. We designed it with comfort and quality in mind – that's why it's fitted with a padded and upholstered headboard, with sprung birch slats.",
                ProductTypeId = 7,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/0/5/2/b052fef9dca93969b9ead73cccd754864f45b6a8_BEDROS052BEI_UK_Roscoe_Double_Bed_Salcombe_Beige_Walnut_Stain_Legs_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/0/7/0/0/0700f596f49cca90c8af5b87451950864cb9307a_BEDROS052BEI_UK_Roscoe_Double_Bed_Salcombe_Beige_Walnut_Stain_Legs_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/1/7/b/5/17b523af9e35d9c707e00a3c2cf02dac0a049d58_BEDROS052BEI_UK_Roscoe_Double_Bed_Salcombe_Beige_Walnut_Stain_Legs_ar3_2_LB06_DM.png" },
                Quantity = 4,
                Slug = "roscoe-double-bed-salcombe-beige-dark-stain-oak-legs",
                CreatedAt = DateTime.Now.AddDays(-35)
            },
            new Product
            {
                Id = 10,
                CategoryId = 3,
                Name = "Trudy",
                Price = 425,
                Title = "Double Ottoman Storage Bed, Ivy Green Velvet & Brass",
                Description = "Traditional design, with a luxury twist. Check out the generous curves, brass legs and welcoming proportions on this bed. Trudy's one to snuggle in to – in style. And did we mention the concealed ottoman storage and recycled fabric?",
                ProductTypeId = 7,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/2/e/8/62e8d5d5bbbdea0e695c868385ae307a27aac2ac_BEDTRU013GRE_UK_Trudy_Double_Storage_Ottoman_Bed_Fir_Green_Velvet_Brass_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/0/a/7/b/0a7bbbecba1ce2889a69eb6149450520d85043bc_BEDTRU013GRE_UK_Trudy_Double_Storage_Ottoman_Bed_Fir_Green_Velvet_Brass_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/3/f/b/2/3fb262d26a457275c94a7ead3f6d7dfa07e2a58e_BEDTRU013GRE_UK_Trudy_Double_Storage_Ottoman_Bed_Fir_Green_Velvet_Brass_ar3_2_LB07_DM.png" },
                Quantity = 4,
                Slug = "trudy-double-ottoman-storage-bed-ivy-green-velvet-brass",
                CreatedAt = DateTime.Now.AddDays(-30)
            },
            new Product
            {
                Id = 11,
                CategoryId = 3,
                Name = "Kano",
                Price = 215,
                Title = "Platform Single Bed, Pine",
                Description = "Kano's the perfect place for you to peacefully slumber, relax and dream. Just look at those clean lines and rounded corners. It's inspired by Japanese design – highly sophisticated and beautifully simple, it’ll turn your bedroom into a zen retreat.",
                ProductTypeId = 8,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/d/d/5/fdd558cfab614da3ccddc4bd8b1d396b867eb68e_BEDKAN005PNE_UK_MADE_Essentials_Kano_Single_Bed_Natural_Pine_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/a/5/1/2a518c36e189339f779f8f0f2eeaac2e7fd6cbfb_BEDKAN005PNE_UK_MADE_Essentials_Kano_Single_Bed_Natural_Pine_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/9/f/3/6/9f36abb1d74908fba8534771d893ef9134931d85_BEDKAN005PNE_UK_MADE_Essentials_Kano_Single_Bed_Natural_Pine_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/e/8/0/e/e80e72e4ead98245858bd689c6625ce1f230443a_BEDKAN005PNE_UK_MADE_Essentials_Kano_Single_Bed_Natural_Pine_ar3_2_LB06_DM.png" },
                Quantity = 4,
                Slug = "kano-platform-single-bed-pine",
                CreatedAt = DateTime.Now.AddDays(-25)
            },
            new Product
            {
                Id = 12,
                CategoryId = 3,
                Name = "Otillia",
                Price = 595,
                Title = "King Size Bed, Dark Navy Velvet with Brass Legs",
                Description = "Curved wing headboard, slim brass legs and padded upholstery – Otillia's hitting all the right bedroom notes. This dreamy frame is revival with a modern twist. Back to bed? Sure.",
                ProductTypeId = 9,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/6/8/2/5682c1342febffe0495de833c42579a3882b68a8_BEDOTT004BLU_UK_Otillia_King_Size_Bed_Dark_Navy_Velvet_Brass_Legs_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/e/8/2/2e823ddf2b44cce4ef6b8f0977e25b4a53642bd4_BEDOTT004BLU_UK_Otillia_King_Size_Bed_Dark_Navy_Velvet_Brass_Legs_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/8/a/6/2/8a62ca13a8042789b609140e122c83202c248b91_BEDOTT004BLU_UK_Otillia_King_Size_Bed_Dark_Navy_Velvet_Brass_Legs_ar3_2_LB06_DM.png" },
                Quantity = 4,
                Slug = "otillia-king-size-bed-dark-navy-velvet-brass-legs",
                CreatedAt = DateTime.Now.AddDays(-20)
            },
            new Product
            {
                Id = 13,
                CategoryId = 3,
                Name = "Ankhara",
                Price = 875,
                Title = "King Size Bed, Rattan & Black Stain Oak, Dark Anthracite Velvet",
                Description = "Cosy, Nordic opulence? Ankhara's into it. A refined combination of black stained oak, dark velvet and cane, this bed feels warm and welcoming. It's what dreams are made of.",
                ProductTypeId = 9,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/9/4/c/594c2e26374846a48fb75ad17c9528942be3b0e0_BEDANK005GRY_UK_Ankhara_King_Size_Bed_Rattan_Black_Stain_Oak_Dark_Anthracite_Velvet_ar3_2_LB02_.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/2/f/a/52fac05ea84a88736c4877d54ad9be00dd4746f1_BEDANK005GRY_UK_Ankhara_King_Size_Bed_Rattan_Black_Stain_Oak_Dark_Anthracite_Velvet_ar3_2_LB01_.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/6/6/e/b66e4239bef8f359654cc689d0fb56745edd86ab_BEDANK005GRY_UK_Ankhara_King_Size_Bed_Rattan_Black_Stain_Oak_Dark_Anthracite_Velvet_ar3_2_LB06_." },
                Quantity = 4,
                Slug = "ankhara-king-size-bed-rattan-black-stain-oak-dark-anthracite-velvet",
                CreatedAt = DateTime.Now.AddDays(-36)
            },
            new Product
            {
                Id = 14,
                CategoryId = 3,
                Name = "Charley",
                Price = 775,
                Title = "King Size Ottoman Storage Bed, Hail Grey",
                Description = "Charley's retro vibes give your bedroom first class design, without the hefty price tag. The buttoned detailing and subtle curved headboard bring personality and style – upholstered in soft hail grey, this king size bed is (almost) too nice to sleep in. And check out the storage underneath.",
                ProductTypeId = 9,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/d/a/b/f/dabf9e764a4769b9cf36b1dc0c6a3c09928ab1cf_BEDCHL016GRY_UK_Charley_King_Size_Bed_Storage_Hail_Grey_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/6/f/1/f6f159c169dc6e84022ab32a550e88e84ff308d3_BEDCHL016GRY_UK_Charley_King_Size_Bed_Storage_Hail_Grey_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/c/9/c/cc9c2f7b966c4bd640b3691e5627780930d6b5be_BEDCHL016GRY_UK_Charley_King_Size_Bed_Storage_Hail_Grey_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/4/0/4/c404791784bd8e24201ef67a84854c9993e66934_BEDCHL016GRY_UK_Charley_King_Size_Bed_Storage_Hail_Grey_ar3_2_LB08_DM.png" },
                Quantity = 8,
                Slug = "charley-king-size-ottoman-storage-bed-hail-grey",
                CreatedAt = DateTime.Now.AddDays(-24)
            },
            new Product
            {
                Id = 15,
                CategoryId = 4,
                Name = "Bow",
                Price = 170,
                Title = "Large Arc Overreach Floor Lamp, Pink & Brass",
                Description = "Down for a little drama? Hello, Bow. This large overreach floor lamp commands attention – even with the lights off. Matte pink and brass bring a Scandi-glam mix – the soft matte shade takes care of the glow. Adjust the arched stem to light up where you need it.",
                ProductTypeId = 10,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/0/c/a/4/0ca470e458d628be31c23438487472cc461f0ca6_FLPBOW024PNK_UK_Bow_Large_Arc_Overreach_Floor_Lamp_Pink_Brass_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/a/d/b/fadb150fd0e9a4eff4d604476c460082590e0b1e_FLPBOW024PNK_UK_Bow_Large_Arc_Overreach_Floor_Lamp_Pink_Brass_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/9/d/7/69d7423f030928e695a2bad25f27976fdddf6d97_FLPBOW024PNK_UK_Bow_Large_Arc_Overreach_Floor_Lamp_Pink_Brass_ar3_2_LB07_DM.png" },
                Quantity = 14,
                Slug = "bow-large-arc-overreach-floor-lamp-pink-brass",
                CreatedAt = DateTime.Now.AddDays(-12)
            },
            new Product
            {
                Id = 16,
                CategoryId = 4,
                Name = "Bree",
                Price = 185,
                Title = "Turned Wood Tripod Floor Lamp, Dark Wood & Green",
                Description = "From cosy corners to large living spaces, brightening your home with Bree is easy. A classic design with a twist, this tripod floor lamp was designed in our studio",
                ProductTypeId = 10,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/a/1/1/e/a11e9e9c9213fe0518d5a14447d9190c30ea1d1f_FLPBRE002GRN_UK_Bree_Turned_Wood_Tripod_Floor_Lamp_Dark_Wood_Green_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/d/1/c/2/d1c2ab01cfcd099f29af41b47ce47ee69ec19d03_FLPBRE002GRN_UK_Bree_Turned_Wood_Tripod_Floor_Lamp_Dark_Wood_Green_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/1/c/3/0/1c308619a5c2946a047724d4cc3f7d5785eb6e6b_FLPBRE002GRN_UK_Bree_Turned_Wood_Tripod_Floor_Lamp_Dark_Wood_Green_ar3_2_LB03_DT.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/4/b/e/7/4be7dd24371cd3fd143a7b6cfb30c456deefdfbf_FLPBRE002GRN_UK_Bree_Turned_Wood_Tripod_Floor_Lamp_Dark_Wood_Green_ar3_2_LB07_DM.png" },
                Quantity = 20,
                Slug = "bree-turned-wood-tripod-floor-lamp-dark-wood-green",
                CreatedAt = DateTime.Now.AddDays(-10)
            },
            new Product
            {
                Id = 17,
                CategoryId = 4,
                Name = "Briz",
                Price = 60,
                Title = "Plug In Wall Light, Grey Glass",
                Description = "Bring the romance to your living room with Briz. Check out the rich mix of materials – from the brushed brass base, to the jewel-like textured glass shade. Designed in-house, this plug in wall light's set to leave a glowing impression (literally).",
                ProductTypeId = 11,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/9/7/b/9/97b91937c4777d20d2e3c7e43161d0982b1822cc_WLPBRI019GRY_UK_Briz_Plug_in_Wall_Light_Grey_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/1/8/d/b/18db86840e54ff8a8fcc2f346dc142095edf1537_WLPBRI019GRY_UK_Briz_Plug_in_Wall_Light_Grey_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/1/c/b/b1cba7bf27be6298c954588bb32b54e1107ea834_WLPBRI019GRY_UK_Briz_Plug_in_Wall_Light_Grey_ar3_2_LB03_LD.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/1/a/0/5/1a055c9379bd6f9e529b161bfc8f659f1241b3d9_WLPBRI019GRY_UK_Briz_Plug_in_Wall_Light_Grey_ar3_2_LB08_DM.png" },
                Quantity = 6,
                Slug = "briz-plug-in-wall-light-grey-glass",
                CreatedAt = DateTime.Now.AddDays(-8)
            },
            new Product
            {
                Id = 18,
                CategoryId = 4,
                Name = "Ogilvy",
                Price = 70,
                Title = "Swing Arm Wall Lamp, Matt Black and Antique Brass",
                Description = "Task lamps always look really cool and industrial in living spaces. So we’ve taken that style for the Ogilvy Collection. A sleek, practical addition to our Deco Luxe look.",
                ProductTypeId = 11,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/7/d/a/c/7dac2cb09308746d8ac7639a2e93481cb1e81578_LGTOGL003BLA_UK_Ogilvy_Swing_Arm_Wall_Lamp_Matt_Black_and_Antique_Brass_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/1/1/8/5118aa73a6133dc0c6020dd065786f093aa0814c_LGTOGL003BLA_UK_Ogilvy_Swing_Arm_Wall_Lamp_Matt_Black_and_Antique_Brass_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/7/7/4/b/774ba8914f65dd13e2c4b52b9366ed164ec6e648_LGTOGL003BLA_UK_Ogilvy_Swing_Arm_Wall_Lamp_Matt_Black_and_Antique_Brass_ar3_2_LB06_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/8/3/2/7/8327fb02d0b38c3e8fccdb02f1a47508aa322983_LGTOGL003BLA_UK_Ogilvy_Swing_Arm_Wall_Lamp_Matt_Black_and_Antique_Brass_ar3_2_LB08_DM.png" },
                Quantity = 8,
                Slug = "ogilvy-swing-arm-wall-lamp-matt-black-and-antique-brass",
                CreatedAt = DateTime.Now.AddDays(-6)
            },
            new Product
            {
                Id = 19,
                CategoryId = 4,
                Name = "Naila",
                Price = 215,
                Title = "Pendant Ceiling Light, Burgundy & Ivory",
                Description = "Sculptural, bold and interesting – that sums up Naila. We created this ceiling light in collaboration with Omayra Maymó, who says it's \"a modern version of a chandelier, using colour and making it more fun and fresher.\" She's won impressive awards for her work, and it's easy to see why. We love the coloured glass and coated metal.",
                ProductTypeId = 12,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/1/1/9/1/11915617c128c7d84a4d5df35e9e2418e369de5e_CLPNAI001IVO_UK_Naila_Pendant_Ceiling_Light_Burgundy_Ivory_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/4/3/3/f/433ff4aaaf34bce1a0978524bfe2ed4e41329f8f_CLPNAI001IVO_UK_Naila_Pendant_Ceiling_Light_Burgundy_Ivory_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/4/3/4/0/43402b4d2467322b7acaea76713f42a20b55ecdf_CLPNAI001IVO_UK_Naila_Pendant_Ceiling_Light_Burgundy_Ivory_ar3_2_LB06_DM.png" },
                Quantity = 12,
                Slug = "naila-pendant-ceiling-light-burgundy-and-ivory",
                CreatedAt = DateTime.Now.AddDays(-16)
            },
            new Product
            {
                Id = 20,
                CategoryId = 4,
                Name = "Albert",
                Price = 55,
                Title = "Flush Ceiling Lamp, Muted Grey",
                Description = "Create a clean, pared-back look with this Scandi-inspired flush ceiling lamp. Albert's a cool combination of powder-coated metal and wood. The key to a calm, Nordic interior. It's great for bringing style to smaller spaces and lower ceilings.",
                ProductTypeId = 12,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/a/0/e/9/a0e937cbd5399428cd9caadfdfbe1af5263e1629_CLPALB028GRY_UK_Albert_Flush_Ceiling_Lamp_Muted_Grey_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/d/0/3/b/d03bc5270b6853df5c5c077708634ee2492bd9cf_CLPALB028GRY_UK_Albert_Flush_Ceiling_Lamp_Muted_Grey_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/3/1/1/a/311a10970051d8a6f2444101376907eb6872d9ff_CLPALB028GRY_UK_Albert_Flush_Ceiling_Lamp_Muted_Grey_ar3_2_LB05_DM.png" },
                Quantity = 8,
                Slug = "albert-flush-ceiling-lamp-muted-grey",
                CreatedAt = DateTime.Now.AddDays(-6)
            },
            new Product
            {
                Id = 21,
                CategoryId = 5,
                Name = "Knox",
                Price = 150,
                Title = "Office Chair, Mustard Corduroy Velvet with Black Legs",
                Description = "This is Knox, a sleek, sophisticated office chair that’ll bring a modern aesthetic to your work space. The single seat cushion and supportive back rest sit on top of a sturdy metal frame and wheels. So, even if you’re chained to your desk, it’s easy to move around.",
                ProductTypeId = 13,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/4/4/e/8/44e8f5598dfd271c66d77e213bc73ce53a381a15_OCHKNX022YEL_UK_Knox_Office_Chair_Mustard_Corduroy_Velvet_with_Black_Legs_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/4/e/4/64e4f7830be1b95b6c599883f42914177dfecea4_OCHKNX022YEL_UK_Knox_Office_Chair_Mustard_Corduroy_Velvet_with_Black_Legs_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/b/4/9/7/b49751f01b7139369578f8691e4f6cdb95c6b23b_OCHKNX022YEL_UK_Knox_Office_Chair_Mustard_Corduroy_Velvet_with_Black_Legs_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/9/e/2/c9e2cbf90bf0f9836b806bb999c2cbd8e3e96c54_OCHKNX022YEL_UK_Knox_Office_Chair_Mustard_Corduroy_Velvet_with_Black_Legs_ar3_2_LB07_DM.png" },
                Quantity = 5,
                Slug = "knox-office-chair-mustard-corduroy-velvet-with-black-legs",
                CreatedAt = DateTime.Now.AddDays(-16)
            },
            new Product
            {
                Id = 22,
                CategoryId = 5,
                Name = "Denham",
                Price = 250,
                Title = "Office Chair, Darby Green & Black Leg",
                Description = "Forget your standard office chairs, Denham's here to help you work comfortably. It's got a padded seat, arms and backrest, and green fabrication that's easy on the eye. We can't promise it'll help you answer those emails, though.",
                ProductTypeId = 13,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/8/9/1/c8916f9987b7b6170f106eac7e69f214dca30093_OCHDEN002GRE_UK_Denham_Office_Chair_Darby_Green_Black_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/4/0/a/240aa03ccf035108717b1f30fcc8b225cbb85089_OCHDEN002GRE_UK_Denham_Office_Chair_Darby_Green_Black_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/d/e/5/e/de5ea1df69aa80afef57c41cfebd7673c37a25a2_OCHDEN002GRE_UK_Denham_Office_Chair_Darby_Green_Black_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/e/f/d/2/efd2981e11f2622cd80e5f32d4f4c6b56be8747d_OCHDEN002GRE_UK_Denham_Office_Chair_Darby_Green_Black_ar3_2_LB07_DM.png" },
                Quantity = 9,
                Slug = "denham-office-chair-darby-green-black-leg",
                CreatedAt = DateTime.Now.AddDays(-18)
            },
            new Product
            {
                Id = 23,
                CategoryId = 5,
                Name = "Jenson",
                Price = 675,
                Title = "Desk, Dark Stain Oak",
                Description = "Beautiful clean lines, tapered boomerang legs, plenty of storage. Jenson makes your home office work for you. Tim Fenby designed this desk with a Scandinavian-refectory look in mind – and the dark stained oak adds sophistication.",
                ProductTypeId = 14,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/2/d/a/22da494dc850cb6aef80732bdebe71c6177f8876_DSKJNS074ZDB_UK_Jenson_Desk_Dark_Stain_Oak_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/5/8/2/c5820297a109098c2be03489588851963ace9b02_DSKJNS074ZDB_UK_Jenson_Desk_Dark_Stain_Oak_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/a/4/0/e/a40ef4a500f14d13feda9f877bd86d2c18745151_DSKJNS074ZDB_UK_Jenson_Desk_Dark_Stain_Oak_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/3/4/2/a/342a678ff7c6385fd51de828a1e3a83a0401e03c_DSKJNS074ZDB_UK_Jenson_Desk_Dark_Stain_Oak_ar3_2_LB06_DM.png" },
                Quantity = 4,
                Slug = "jenson-desk-dark-stain-oak",
            },
            new Product
            {
                Id = 24,
                CategoryId = 5,
                Name = "Leonie",
                Price = 450,
                Title = "Wide Desk, Oak",
                Description = "A design collaboration with SmithMatthias, take your office space to the next level with Leonie. Complete with a cable management feature, 2 handy side drawers, 1 large drawer, and space for your computer up top. Solid oak and oak veneer keep it natural.",
                ProductTypeId = 14,
                Images = new string[] { "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/9/6/5/1/965170d0d89bf725fd7a657382cd5423b1517cfc_DSKLEO003ZOK_UK_Leonie_Wide_Desk_Oak_ar3_2_LB01_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/8/c/1/f8c1aea53bab3547f5f7f496a9ee2e09cef7f664_DSKLEO003ZOK_UK_Leonie_Wide_Desk_Oak_ar3_2_LB02_LS.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/2/9/0/1/290145d3ff07ceb90483acdf03c50fce2e81d44f_DSKLEO003ZOK_UK_Leonie_Wide_Desk_Oak_ar3_2_LB03_LD.jpg", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/0/a/c/50ac9938f485f4e4955d354a8987b6e36ceca330_DSKLEO003ZOK_UK_Leonie_Wide_Desk_Oak_ar3_2_LB04_PS.png", "https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/5/c/0/c/5c0c6c8cfed1103c2be3be796e07e4a5b4c898c9_DSKLEO003ZOK_UK_Leonie_Wide_Desk_Oak_ar3_2_LB07_DM.png" },
                Quantity = 4,
                Slug = "leonie-wide-desk-oak",
                CreatedAt = DateTime.Now.AddDays(-18)
            });


    }
}
