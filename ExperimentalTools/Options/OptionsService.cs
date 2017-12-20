using System.Composition;

namespace ExperimentalTools.Options
{
    [Export(typeof(IOptions))]
    internal class OptionsService : IOptions
    {
        public string VSVersion => OptionsBucket.Instance.VSVersion;

        public bool IsFeatureEnabled(string identifier)
        {
            var features = OptionsBucket.Instance.Features;
            return features.ContainsKey(identifier) ? features[identifier] : false;
        }
    }
}
