using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        List<Offer> offers = new List<Offer>();
        List<Offer> highestOffer = new List<Offer>();
        List<House> houses = new List<House>();
        List<House> acceptedHouses = new List<House>();
        List<Apartment> apartments = new List<Apartment>();
        List<Apartment> acceptedApartments = new List<Apartment>();
        int test;
        double test2;
        string line = "";
        string type, descrptionx, statusx, stylex, streetx, cityx, statex, aptx, ownerNamex, realtorNamex, ownerPhonex, realtorPhonex, companyx, namex;
        double sizex, pricex;

        int agex, idx, housenumberx, zipx;

        private void button8_Click(object sender, EventArgs e)
        {/*remove property with extra step to ensure proper choice. Remove from run time list, rewrite text log with what is now in list(inefficient)*/
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove selected property?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (type == "house")
                {
                    
                    for(int i = 0; i < houses.Count; i++) 
                    {
                        if (houses[i].Id == acceptedHouses[listBox1.SelectedIndex].Id)
                        {
                            houses.Remove(houses[i]);
                        }
                    }
                    System.IO.File.WriteAllText("Houselog.txt", string.Empty);
                    using (StreamWriter hLog = File.AppendText("Houselog.txt"))
                    foreach(House house in houses)
                    {
                            hLog.WriteLine(house.Id);
                            hLog.WriteLine(house.Location.Housenumber);
                            hLog.WriteLine(house.Location.Street);
                            hLog.WriteLine(house.Location.City);
                            hLog.WriteLine(house.Location.State);
                            hLog.WriteLine(house.Location.Zip);
                            hLog.WriteLine(house.Description);
                            hLog.WriteLine(house.Status);
                            hLog.WriteLine(house.Style);
                            hLog.WriteLine(house.Size);
                            hLog.WriteLine(house.Age);
                            hLog.WriteLine(house.Price);
                            hLog.WriteLine(house.PropertyOwner.Name);
                            hLog.WriteLine(house.PropertyOwner.Phone);
                            hLog.WriteLine(house.Realtor.Name);
                            hLog.WriteLine(house.Realtor.Phone);
                            hLog.WriteLine(house.Realtor.Company);


                        }
                }
                if (type == "apt")
                {
                    
                    for (int i = 0; i < apartments.Count; i++)
                   
                    {
                        if (apartments[i].Id == acceptedApartments[listBox1.SelectedIndex].Id)
                        {
                            apartments.Remove(apartments[i]);
                        }
                    }
                    System.IO.File.WriteAllText("Apartmentlog.txt", string.Empty);
                    using (StreamWriter aLog = File.AppendText("Apartmentlog.txt"))
                        foreach (Apartment apartment in apartments)
                        {
                            aLog.WriteLine(apartment.Id);
                            aLog.WriteLine(apartment.Location.Housenumber);
                            aLog.WriteLine(apartment.Location.Street);
                            aLog.WriteLine(apartment.Location.City);
                            aLog.WriteLine(apartment.Location.State);
                            aLog.WriteLine(apartment.Location.Zip);
                            aLog.WriteLine(apartment.Description);
                            aLog.WriteLine(apartment.Status);
                            aLog.WriteLine(apartment.Style);
                            aLog.WriteLine(apartment.Size);
                            aLog.WriteLine(apartment.Age);
                            aLog.WriteLine(apartment.Rent);
                            aLog.WriteLine(apartment.PropertyOwner.Name);
                            aLog.WriteLine(apartment.PropertyOwner.Phone);
                            aLog.WriteLine(apartment.Realtor.Name);
                            aLog.WriteLine(apartment.Realtor.Phone);
                            aLog.WriteLine(apartment.Realtor.Company);
                            aLog.WriteLine(apartment.Location.ApartmentNumber);


                        }

                }

                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
                label18.Text = "";
                label26.Text = "";
                label27.Text = "";
                label28.Text = "";
                label29.Text = "";
                label30.Text = "";
                label37.Text = "";
                label38.Text = "";



            }
            else if (dialogResult == DialogResult.No){}
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {/*add offer to list of offers based on ID*/
            if (type == "house")
            {
                idx = acceptedHouses[listBox1.SelectedIndex].Id;
                namex = textBox2.Text;
                pricex = double.Parse(textBox3.Text);
            }
            if (type == "apt")
            {
                idx = acceptedApartments[listBox1.SelectedIndex].Id;
                namex = textBox2.Text;
                pricex = int.Parse(textBox3.Text);
            }
            Offer newOffer = new Offer(idx, namex, pricex);
            offers.Add(newOffer);
            using (StreamWriter oLog = File.AppendText("Offers.txt"))
            {
                oLog.WriteLine(idx);
                oLog.WriteLine(namex);
                oLog.WriteLine(pricex);

            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {/*go back to login if not auth, if auth then open user options*/
            if (Form1.auth)
            {
                this.Hide();
                Form3 gb1 = new Form3();
                gb1.ShowDialog();
                this.Close();
            }
            if (Form1.auth == false)
            {
                this.Hide();
                Form1 gb2 = new Form1();
                gb2.ShowDialog();
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "apt";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "house";
        }

        private void label30_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {/*load up selected property information*/
            if (listBox1.SelectedIndex >=0)
            {
                highestOffer.Clear();
                if (type == "house")
                {
                    label11.Text = acceptedHouses[listBox1.SelectedIndex].HouseAddress();
                    label12.Text = acceptedHouses[listBox1.SelectedIndex].Description;
                    label13.Text = acceptedHouses[listBox1.SelectedIndex].Status;
                    label14.Text = acceptedHouses[listBox1.SelectedIndex].Style;
                    label15.Text = acceptedHouses[listBox1.SelectedIndex].Size.ToString();
                    label16.Text = acceptedHouses[listBox1.SelectedIndex].Age.ToString();
                    label17.Text = acceptedHouses[listBox1.SelectedIndex].Price.ToString();
                    label18.Text = acceptedHouses[listBox1.SelectedIndex].Id.ToString();
                    label26.Text = acceptedHouses[listBox1.SelectedIndex].Realtor.Name;
                    label27.Text = acceptedHouses[listBox1.SelectedIndex].Realtor.Phone;
                    label28.Text = acceptedHouses[listBox1.SelectedIndex].Realtor.Company;
                    if (Form1.auth)
                    {
                        label29.Text = acceptedHouses[listBox1.SelectedIndex].PropertyOwner.Name;
                        label30.Text = acceptedHouses[listBox1.SelectedIndex].PropertyOwner.Phone;
                        foreach (Offer offer in offers)
                        {
                            if (offer.Id == acceptedHouses[listBox1.SelectedIndex].Id)
                            {
                                highestOffer.Add(offer);
                            }
                        }
                        if (highestOffer.Count > 0)
                        {
                            offers.Sort((Offer p1, Offer p2) => p1.Amount.CompareTo(p2.Amount));
                            label37.Text = highestOffer[highestOffer.Count - 1].Amount.ToString();
                            label38.Text = highestOffer[highestOffer.Count - 1].Name;
                        }
                    }
                    else
                    {
                        label29.Text = "Restricted information";
                        label30.Text = "Restricted information";
                    }
                }
                if (type == "apt")
                {
                    label11.Text = acceptedApartments[listBox1.SelectedIndex].ApartmentAddress();
                    label12.Text = acceptedApartments[listBox1.SelectedIndex].Description;
                    label13.Text = acceptedApartments[listBox1.SelectedIndex].Status;
                    label14.Text = acceptedApartments[listBox1.SelectedIndex].Style;
                    label15.Text = acceptedApartments[listBox1.SelectedIndex].Size.ToString();
                    label16.Text = acceptedApartments[listBox1.SelectedIndex].Age.ToString();
                    label17.Text = acceptedApartments[listBox1.SelectedIndex].Rent.ToString() + " per month";
                    label18.Text = acceptedApartments[listBox1.SelectedIndex].Id.ToString();
                    label26.Text = acceptedApartments[listBox1.SelectedIndex].Realtor.Name;
                    label27.Text = acceptedApartments[listBox1.SelectedIndex].Realtor.Phone;
                    label28.Text = acceptedApartments[listBox1.SelectedIndex].Realtor.Company;
                    if (Form1.auth)
                    {
                        label29.Text = acceptedApartments[listBox1.SelectedIndex].PropertyOwner.Name;
                        label30.Text = acceptedApartments[listBox1.SelectedIndex].PropertyOwner.Phone;
                        foreach (Offer offer in offers)
                        {
                            if (offer.Id == acceptedApartments[listBox1.SelectedIndex].Id)
                            {
                                highestOffer.Add(offer);
                            }
                        }
                        if (highestOffer.Count>0)
                        {
                            offers.Sort((Offer p1, Offer p2) => p1.Amount.CompareTo(p2.Amount));
                            label37.Text = highestOffer[highestOffer.Count - 1].Amount.ToString();
                            label38.Text = highestOffer[highestOffer.Count - 1].Name;
                        }
                    }
                    else
                    {
                        label29.Text = "Restricted information";
                        label30.Text = "Restricted information";
                    }

                }
            }
        }

        public Form2()
        {/*create run time list of all apartments, houses, and offers. Allows extra options if authenticated*/
            InitializeComponent();
            radioButton1.Checked = true;
            if (Form1.auth == false)
            {
                button7.Hide();
                button8.Hide();
                textBox2.Hide();
                textBox3.Hide();
                label31.Hide();
                label32.Hide();
                label33.Hide();
                label34.Hide();
                label37.Hide();
                label38.Hide();

            }
            if (Form1.auth == true)
            {
                button7.Show();
                button8.Show();
                textBox2.Show();
                textBox3.Show();
                label31.Show();
                label32.Show();
                label33.Show();
                label34.Show();
                label37.Show();
                label38.Show();
            }
            StreamReader FileH = new StreamReader("Houselog.txt");
            StreamReader FileA = new StreamReader("Apartmentlog.txt");
            StreamReader FileO = new StreamReader("Offers.txt");
            while (line != null)
            {
                for (int i = 0; i < 17; i++)
                {
                    line = FileH.ReadLine();
                    if (line != null)
                    {
                        switch (i)
                        {
                            case 0:
                                if (int.TryParse(line, out test)) { idx = test; }
                                break;
                            case 1:
                                if (int.TryParse(line, out test)) { housenumberx = test; }
                                break;
                            case 2:
                                streetx = line;
                                break;
                            case 3:
                                cityx = line;
                                break;
                            case 4:
                                statex = line;
                                break;
                            case 5:
                                if (int.TryParse(line, out test)) { zipx = test; }
                                break;
                            case 6:
                                descrptionx = line;
                                break;
                            case 7:
                                statusx = line;
                                break;
                            case 8:
                                stylex = line;
                                break;
                            case 9:
                                if (double.TryParse(line, out test2)) { sizex = test2; }
                                break;
                            case 10:
                                if (int.TryParse(line, out test)) { agex = test; }
                                break;
                            case 11:
                                if (double.TryParse(line, out test2)) { pricex = test2; }
                                break;
                            case 12:
                                ownerNamex = line;
                                break;
                            case 13:
                                ownerPhonex = line;
                                break;
                            case 14:
                                realtorNamex = line;
                                break;
                            case 15:
                                realtorPhonex = line;
                                break;
                            case 16:
                                companyx = line;
                                break;
                        }
                    }
                }
                if (line != null)
                {
                    Agent tempRealtor = new Agent(realtorNamex, realtorPhonex, companyx);
                    Owner tempOwner = new Owner(ownerNamex, ownerPhonex, tempRealtor);
                    AddressHouse newAddress = new AddressHouse(housenumberx, streetx, cityx, statex, zipx);
                    House newHouse = new House(descrptionx, statusx, stylex, sizex, agex, pricex, newAddress, idx, tempOwner, tempRealtor);
                    houses.Add(newHouse);
                }
            }
            FileH.Close();
            line = "";
            while (line != null)
            {
                for (int i = 0; i < 18; i++)
                {
                    line = FileA.ReadLine();
                    if (line != null)
                    {
                        switch (i)
                        {
                            case 0:
                                if (int.TryParse(line, out test)) { idx = test; }
                                break;
                            case 1:
                                if (int.TryParse(line, out test)) { housenumberx = test; }
                                break;
                            case 2:
                                streetx = line;
                                break;
                            case 3:
                                cityx = line;
                                break;
                            case 4:
                                statex = line;
                                break;
                            case 5:
                                if (int.TryParse(line, out test)) { zipx = test; }
                                break;
                            case 6:
                                descrptionx = line;
                                break;
                            case 7:
                                statusx = line;
                                break;
                            case 8:
                                stylex = line;
                                break;
                            case 9:
                                if (double.TryParse(line, out test2)) { sizex = test2; }
                                break;
                            case 10:
                                if (int.TryParse(line, out test)) { agex = test; }
                                break;
                            case 11:
                                if (double.TryParse(line, out test2)) { pricex = test2; }
                                break;
                            case 12:
                                ownerNamex = line;
                                break;
                            case 13:
                                ownerPhonex = line;
                                break;
                            case 14:
                                realtorNamex = line;
                                break;
                            case 15:
                                realtorPhonex = line;
                                break;
                            case 16:
                                companyx = line;
                                break;
                            case 17:
                                aptx = line;
                                break;
                        }
                    }
                }
                if (line != null)
                {
                    Agent tempRealtor = new Agent(realtorNamex, realtorPhonex, companyx);
                    Owner tempOwner = new Owner(ownerNamex, ownerPhonex, tempRealtor);
                    AddressApartment newAddressA = new AddressApartment(housenumberx, streetx, cityx, statex, zipx, aptx);
                    Apartment newApt = new Apartment(descrptionx, statusx, stylex, sizex, agex, pricex, newAddressA, idx, tempOwner, tempRealtor);
                    apartments.Add(newApt);
                }
            }
            FileA.Close();
            line = "";
            while (line != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    line = FileO.ReadLine();
                    if (line != null)
                    {
                        switch (i)
                        {
                            case 0:
                                if (int.TryParse(line, out test)) { idx = test; }
                                break;
                            case 1:
                                namex = line;
                                break;
                            case 2:
                                if (double.TryParse(line, out test2)) { pricex = test2; }
                                break;
                        }
                    }
                }
                if (line != null)
                {
                    Offer tempOffer = new Offer(idx, namex, pricex);
                    offers.Add(tempOffer);
                }
            }
            FileO.Close();


        }
        private void button3_Click(object sender, EventArgs e)
        {/*search by zip*/
            listBox1.Items.Clear();
            acceptedHouses.Clear();
            acceptedApartments.Clear();
            highestOffer.Clear();
            if (type == "house")
            {
                foreach (House place in houses)
                {
                    if (place.Location.Zip == int.Parse(textBox1.Text))
                    {

                        acceptedHouses.Add(place);

                    }
                }
                foreach (House place in acceptedHouses)
                {
                    listBox1.Items.Add(place.HouseAddress());
                }
            }
            if (type == "apt")
            {
                foreach (Apartment places in apartments)
                {
                    if (places.Location.Zip == int.Parse(textBox1.Text))
                    {
                        acceptedApartments.Add(places);
                    }
                }
                foreach (Apartment places in acceptedApartments)
                {
                    listBox1.Items.Add(places.ApartmentAddress());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {/*search by state*/
            listBox1.Items.Clear();
            acceptedHouses.Clear();
            acceptedApartments.Clear();
            if (type == "house")
            {
                foreach (House place in houses)
                {
                    if (place.Location.State == textBox1.Text)
                    {

                        acceptedHouses.Add(place);

                    }
                }
                foreach (House place in acceptedHouses)
                {
                    listBox1.Items.Add(place.HouseAddress());
                }
            }
            if (type == "apt")
            {
                foreach (Apartment places in apartments)
                {
                    if (places.Location.State == textBox1.Text)
                    {
                        acceptedApartments.Add(places);
                    }
                }
                foreach (Apartment places in acceptedApartments)
                {
                    listBox1.Items.Add(places.ApartmentAddress());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {/*search by city*/
            listBox1.Items.Clear();
            acceptedHouses.Clear();
            acceptedApartments.Clear();
            if (type == "house")
            {
                foreach (House place in houses)
                {
                    if (place.Location.City == textBox1.Text)
                    {

                        acceptedHouses.Add(place);

                    }
                }
                foreach (House place in acceptedHouses)
                {
                    listBox1.Items.Add(place.HouseAddress());
                }
            }
            if (type == "apt")
            {
                foreach (Apartment places in apartments)
                {
                    if (places.Location.City ==textBox1.Text)
                    {
                        acceptedApartments.Add(places);
                    }
                }
                foreach (Apartment places in acceptedApartments)
                {
                    listBox1.Items.Add(places.ApartmentAddress());
                }
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int index = this.listBox1.IndexFromPoint(e.Location);
            label11.Text=*/

        }

       
    }
}
