using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }
        
        public void UpdateQuality()
        {
            AgedBrie brie = new AgedBrie();
            DexterityVestAndElixir vest = new DexterityVestAndElixir();
            Sulfuras sulfuras = new Sulfuras();
            BackstagePassesConcert backstageConcert = new BackstagePassesConcert();
            ConjuredCake conjuredManaCake = new ConjuredCake();
            Elixir elixir = new Elixir();
            
            
            for (var i = 0; i < Items.Count; i++)
            {
                string[] listOfSplitItemName = Items[i].Name.Split(' ');
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            brie.UpdateAgedBrie(Items[i]);
                        }
                        brie.UpdateAgedBrie(Items[i]);
                        break;
                    
                    case "+5 Dexterity Vest":
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            vest.UpdateDexterityVest(Items[i]);
                        }
                        vest.UpdateDexterityVest(Items[i]);
                        break;
                    
                    case "Elixir of the Mongoose":
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            elixir.UpdateElixir(Items[i]);
                        }
                        elixir.UpdateElixir(Items[i]);
                        break;
                    
                    case "Sulfuras, Hand of Ragnaros" :
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            sulfuras.UpdateSulfuras(Items[i]);
                        }
                        sulfuras.UpdateSulfuras(Items[i]);
                        break;
                    
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            backstageConcert.UpdateBacksatagePassesConcert(Items[i]);
                        }
                        backstageConcert.UpdateBacksatagePassesConcert(Items[i]);
                        break;
                    
                    case "Conjured Mana Cake":
                        
                        conjuredManaCake.UpdateConjuredCake(Items[i]);
                        break;
                    
                    default:
                        if (listOfSplitItemName[0] == "Conjured")
                        {
                            if (listOfSplitItemName[1] == "Aged")
                            {
                                brie.UpdateConjuredAgedBrie(Items[i]);
                            }
                            if (listOfSplitItemName[2] == "Dexterity")
                            {
                                vest.UpdateConjuredDexterityVest(Items[i]);
                            }
                            if (listOfSplitItemName[1] == "Elixir")
                            {
                                elixir.UpdateConjuredElixir(Items[i]);
                            }
                            if (listOfSplitItemName[1] == "Backstage")
                            {
                                backstageConcert.UpdateConjuredBacksatagePassesConcert(Items[i]);
                            }
                        }

                        break;
                    
                    
                        
                }
                Items[i].SellIn = Items[i].SellIn - 1;
                
            }

            
        }
    }

    public class AgedBrie
    {
        public void UpdateAgedBrie(Item item)
        {
            if (item.SellIn > 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 1;  
            }
                        
            if (item.SellIn <= 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 2;  
            }
            
        }
        
        public void UpdateConjuredAgedBrie(Item item)
        {
            if (item.SellIn > 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 2;  
            }
                        
            if (item.SellIn <= 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 4;  
            }
            
        }
    }

    public class DexterityVestAndElixir
    {
        public void UpdateDexterityVest(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 1;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
        }
        
        public void UpdateConjuredDexterityVest(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 4;  
            }
        }
    }
    
    public class Elixir
    {
        public void UpdateElixir(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 1;  
            }
           
        }
        public void UpdateConjuredElixir(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
           
        }
    }

    public class Sulfuras
    {
        public void UpdateSulfuras(Item item)
        {
            item.Quality = 80;
            item.SellIn += 1;
        }
    }

    public class BackstagePassesConcert
    {
        public void UpdateBacksatagePassesConcert(Item item)
        {
            if (item.Quality < 50 && item.SellIn < 6)
            {
                item.Quality = item.Quality +3 ;
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }

            if (item.Quality < 50 && item.SellIn >= 6 && item.SellIn < 11)
            {
                item.Quality = item.Quality +2 ;  
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }
                        
            if (item.Quality < 50 && item.SellIn >= 11)
            {
                item.Quality = item.Quality + 1;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
        }
        
        public void UpdateConjuredBacksatagePassesConcert(Item item)
        {
            if (item.Quality < 50 && item.SellIn < 6)
            {
                item.Quality = item.Quality +3 ;
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }

            if (item.Quality < 50 && item.SellIn >= 6 && item.SellIn < 11)
            {
                item.Quality = item.Quality +4 ;  
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }
                        
            if (item.Quality < 50 && item.SellIn >= 11)
            {
                item.Quality = item.Quality + 2;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
        }
    }

    public class ConjuredCake
    {
        public void UpdateConjuredCake(Item item)
        {
            if (item.Quality < 50 && item.Quality >0 && item.SellIn >0)
            {
                item.Quality = item.Quality - 1;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}