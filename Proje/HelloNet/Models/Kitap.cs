using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//! Buradaki isim ile diğer sayfalarda kullanmak için import ediyoruz.
namespace HelloNet.Models
{
  //? Bu class içindeki verileri tutacağız bunun için class oluşturduk.
  public class Kitap
  {
    public int ID { get; set; }
    public string KitapAd { get; set; }
    public string Yazar { get; set; }
  }
}
