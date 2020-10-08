using Newtonsoft.Json;

namespace catalogBooks.Src
{
    public class JsonToObject
    {
        public void ConvertJson(string fileJson)
        {
            Catalog deserializedCatalog = JsonConvert.DeserializeObject<Catalog>(fileJson);
        }
    }
}
