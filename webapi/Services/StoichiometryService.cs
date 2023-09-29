using cognisseum.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using NCDK;
using NCDK.Smiles;
using System.ComponentModel.DataAnnotations;

namespace cognisseum.Services
{
    public class StoichiometryService
    {

        public StoichiometryService(CgnContext db) => Db = db;

        public float MolecularMass(string smiles)
        {
            var sp = new SmilesParser();
            var mol = sp.ParseSmiles(smiles);
            var buckets = new Dictionary<IAtom, int>();
            foreach (var m in mol.Atoms)
            {
                if (buckets.ContainsKey(m))
                {
                    buckets[m] += 1;
                }
                else
                {
                    buckets[m] = 1;
                }
            }

            float result = 0;

            foreach (var a in buckets.Keys)
            {
                var e = Db.Elements.AsQueryable().Where(x => x.Symbol == a.Symbol).SingleOrDefault();
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
