using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instagram
{
    public class DBUpdater
    {
        public void UpdatePhotoUrls()
        {            
            using (InstagramEntities db = new InstagramEntities())
            {
                for (int i = 0; i < 257; i++)         
                {
                    photos photo = db.photos.Where(s => s.id == i + 1).FirstOrDefault();
                    photo.image_url = "https://picsum.photos/id/"+ i +"/500/580";
                    db.SaveChanges();
                }
            }
        }
    }
}
