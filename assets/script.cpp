ternal sealed class ContentInjector
{
    private const string FreeRecipeIngredientList = "(O)388 0";
    private const string ObjectSpriteAsset = "Mods/" + ModItemCatalog.UniqueId + "/Items";
    private const string BigCraftableSpriteAsset = "Mods/" + ModItemCatalog.UniqueId + "/BigCraftables";
    private const string ObjectSpriteResource = "SVSAP.Assets.Items.png";
    private const string BigCraftableSpriteResource = "SVSAP.Assets.BigCraftables.png";

    private readonly Func<ModConfig> getConfig;
    private readonly IMonitor monitor;

    public ContentInjector(Func<ModConfig> getConfig, IMonitor monitor)
    {
        this.getConfig = getConfig;
        this.monitor = monitor;
    }

    public void OnAssetRequested(object? sender, AssetRequestedEventArgs e)
    {
        if (e.NameWithoutLocale.IsEquivalentTo(ObjectSpriteAsset))
        {
            e.LoadFrom(() => LoadEmbeddedTexture(ObjectSpriteResource), AssetLoadPriority.Exclusive);
            return;
        }

        if (e.NameWithoutLocale.IsEquivalentTo(BigCraftableSpriteAsset))
        {
            e.LoadFrom(() => LoadEmbeddedTexture(BigCraftableSpriteResource), AssetLoadPriority.Exclusive);
            return;
        }

        if (e.NameWithoutLocale.IsEquivalentTo("Data/Objects"))
        {
            e.Edit(asset =>
            {
                var data = asset.AsDictionary<string, ObjectData>().Data;

                var spriteIndex = 0;
                foreach (var item in ModItemCatalog.ObjectItems)
                {
