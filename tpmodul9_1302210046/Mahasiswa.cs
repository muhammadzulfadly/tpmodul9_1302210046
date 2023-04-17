using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210046
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : Controller
    {
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "Muhammad Zulfadly", Nim = "1302210046"},
            new mahasiswa {Nama = "Herlin Priatna", Nim = "1302210046"},
            new mahasiswa {Nama = "Syahran syhaputra", Nim = "1302210046"},
            new mahasiswa {Nama = "Afny Latifa", Nim = "1302210046"},
            new mahasiswa {Nama = "Nurul Pratiwi", Nim = "1302210046"}
        };

        // GET: api/<Mahasiswa>
        // mereturn output berupa list dari semua obj mhs
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // POST api/<Mahasiswa>
        // menambah obj mhs baru 
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        // DELETE api/<Mahasiswa>/{id}
        // menghapus obj mhs ke-i
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}

