using Orchard.UI.Resources;

namespace MarkBartha.BasicBlogTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
        }
    }
}