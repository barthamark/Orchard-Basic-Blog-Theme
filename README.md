# Basic Blog Theme for Orchard CMS

Simple and clean blog theme for Orchard CMS created by Márk Bartha. 

This theme is using the [Pretty Good Orchard Base Theme](https://github.com/Lombiq/Pretty-Good-Bootstrap-Base-Theme) as a base theme which was created by [Lombiq](https://lombiq.com).

## Some notes about the theme

* The theme uses some fields as placeholders to display various contents like social sharing icons.
* This theme doesn't support multi-level menu yet.
* Some zones have been removed from the layout which are the following: `AsideFirst`, `TripelFirst`, `TripelSecond`, `TripelThird`, `FooterQuadFirst`, `FooterQuadSecond`, `FooterQuadThird`, `FooterQuadFourth`.
* Branding shape is not displayed. A widget must be used for branding.
* Widgets in the Navigation zone (possibly the MenuWidgets) are pulled right except the first one which is pulled left.
* HTML menu items with images can be used in the Navigation zone.
* Featured zone has a background with the primary color.
* Blog post content item summary display shape has been overridden to be able to display the feature image.
* User shape containing the username or the link to the log on page is also hidden.

## Initialize the theme with recipes

There is a recipe in the Recipes folder of the theme that can be imported in order to create FeaturedImage and Social content parts. It will also attach these parts to the BlogPost content type. You can import it using the ImportExport module (import the *Recipes/BasicBlogThemeParts.recipe.xml* file) or you can go to the Recipes tab on the Modules page on the Dashboard and execute the *Basic Blog Theme - Parts* recipe.

If you are using this theme on DotNest you need to import this recipe manually using the ImportExport module.

## How to use some of the features

### Adding featured images to blog posts

1. Create a `FeaturedImagePart` on the Orchard Dashboard.
2. Add a `MediaLibraryPickerField` to this part and give `FeaturedImage` as a name.
3. Attach this part on the `BlogPost` content type or any content type you'd like.

### Adding social content-sharing icons

1. Create a `SocialPart` on the Orchard Dashboard.
2. Add an `InputField` to this part and give `ContentSharing` as a name.
3. Attach this part on any content type.

Furthermore, you can add the `BasicBlog__ContentSharing` shape anywhere on the site (e.g. shape element on a layout) to display the same icons making it possible to share that page.

### Display summaries with only the title and published date

You need to use the `TitleSummary` display type. Here's one example of how to achieve that.

1. Go to the Queries page on the Orchard Dashboard.
2. Create a Query and add the filters you want. Add a new layout with an unordered list and set `TitleSummary` to the display type field.
3. Go to the Widgets page and create a Projection Widget in the AsideSecond zone.
4. Select the query with the newly created layout and save the widget.

### Adding social icons to the menu

HTML menu items are styled and can be used to display various images like social icons. 

1. Go to the Navigation page on the Dashboard.
2. Create a new Menu and add the HTML menu items with the icons.
3. Go to the Widgets page and create a MenuWidget after the main menu.

## Ad-hoc shapes

There are a few ad-hoc shapes added to the theme that can be used from other shape overrides or you can just display it using the shape element in a Layout.

* `BasicBlog__ContentSharing`: displays content-sharing icons that will make the user able to share the current page where the shape is displayed.
* `BasicBlog__ShortSummary` and `BasicBlog__LongSummary`: shortens a given HTML text (Text dynamic property is required). It's useful if you want to display the shortened text of the BodyPart or a TextField containing HTML markup. The shorter one is displaying about 160 characters and only displays the first paragraph. The longer one is displaying about 300 characters.
* `BasicBlog__ContentCreatedDateLocalized`: displays the localized creation date of the given content (it tries to get the date from the CreatedUtc property first, if it is not set then the content from the ContentItem property finally the ContentPart property). Optionally you can pass a custom date format using the CustomFormat property, otherwise, the `MMMM dd, yyyy` format will be used.