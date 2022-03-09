using System.Collections.Generic;

namespace adduo.elephant.domain.dtos.debts.bundler_items
{
    public class RecurrentBundler : ItemBundler
    {
        public List<RecurrentValueBundler> Values { get; set; } = new List<RecurrentValueBundler>();
    }
}
