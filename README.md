# Basic Blog Theme for Orchard CMS

Simple and clean blog theme for Orchard CMS created by Márk Bartha. This theme is using the [Pretty Good Orchard Base Theme](https://github.com/Lombiq/Pretty-Good-Bootstrap-Base-Theme) created by [Lombiq](https://lombiq.com). 

## Some notes about the theme

* The theme uses some fields as placeholders to display various contents like social sharing icons - see the instructions below.
* This theme doesn't support multi-level menu yet.
* Some zones has been removed from the layout which are the following: `AsideFirst`, `TripelFirst`, `TripelSecond`, `TripelThird`, `FooterQuadFirst`, `FooterQuadSecond`, `FooterQuadThird`, `FooterQuadFourth`.
* Featured zone has a green background.
* Blog post content item summary display shape has been overriden to be able to display the feature image.
* 

## How to use the theme

### Adding feature images to blog posts

1. Create a `FeatureImagePart` on the Orchard Dashboard.
2. Add a `MediaLibraryPickerField` to this part and give `FeatureImage` as a name.
3. Attach this part on the `BlogPost` content type or any content type you'd like.

### Adding social content sharing icons

1. Create a `SocialPart` on the Orchard Dashboard.
2. Add an `InputField` to this part and give `ContentSharing` as a name.
3. Attach this part on any content type.

Furthermore, you can add `Shape__ContentSharing` shape anywhere on the site to display the same icons making it possible to share that page.

## Display summaries with only the title and published date

You need to use the `TitleSummary` display type. Here's one example on how to achieve that.

1. Go to the Queries page on the Orchard Dashboard.
2. Create a Query and add the filters you want. Add a new layout with an unordered list and set `TitleSummary` to the display type field.
3. Go to the Widgets page and create a Projection Widget in the AsideSecond zone.
4. Select the query with the newly created layout and save the widget.