using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_EntityFramework
{
    [Table("RentTransaction")]
    public class RentTransaction
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("name")]
        public string UserName { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("album_id")]
        public string AlbumId { get; set; }
        [Column("status_rent")]
        public string StatusRent { get; set; }
    }
}
