using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_232410101005_utspbo
{
    List<Tugas> list = new List<Tugas>();
    public partial class HalamanTugas : Form
    {
        public HalamanTugas()
        {
            InitializeComponent();

            Tugas tugas = new Tugas();
            tugas.judul = "Pemrograman berbasis objek";
            tugas.deskripsi = "Membuat program winform taks management";
            tugas.dedline = new DateOnly(2005, 03, 29);
            list.Add (tugas);

            dataGridView1.DataSource = list;

        }

        private void HalamanTugas_Load(object sender, EventArgs e)
        {

        }
    }
}


