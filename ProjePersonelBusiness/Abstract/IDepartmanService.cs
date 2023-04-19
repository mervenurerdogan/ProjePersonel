using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Abstract
{
    public interface IDepartmanService:IBaseService<Departman>
    {
        int GetirToplamDepartmanSayisi();
        List<Departman> GetirDepartmanCalisanPersonel(int personelID);
    }
}
