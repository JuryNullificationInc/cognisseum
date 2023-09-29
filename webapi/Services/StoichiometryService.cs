using cognisseum.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using NCDK;
using NCDK.Smiles;
using System.ComponentModel.DataAnnotations;
using webapi.Services;

namespace cognisseum.Services
{
    public class StoichiometryService : DbServiceBase
    {

        public StoichiometryService(CgnContext db) : base(db) { }

        public float MolecularMass(string smiles)
        {
            var sp = new SmilesParser();
            var mol = sp.ParseSmiles(smiles);
            var buckets = new Dictionary<string, int>();
            foreach (var m in mol.Atoms)
            {
                if (buckets.ContainsKey(m.Symbol))
                {
                    buckets[m.Symbol] += 1;
                }
                else
                {
                    buckets[m.Symbol] = 1;
                }
            }

            float result = 0;

            foreach (var a in buckets.Keys)
            {
                var e = GetElementBySymbol(a);
                if (e != null)
                {
                    result += (float)e.AtomicWeight * buckets[a];
                }
            }
            
            return result;
        }

        private CgnContext Db { get; set; }
    }
}
