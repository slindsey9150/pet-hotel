using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using pet_hotel;

namespace pet_hotel
{
    public enum PetBreedType {
        
            Aussie,
            Corgi,
            Golden_Retriever,
            Lab,
            Pit_Bull
        
    }
    public enum PetColorType {
        
            Black,
            Brown,
            Golden,
            Marbled,
            Spotted,
            White

        
    }
    public class Pet {

        public int id {get; set;}
        public string? name {get; set;}
        public bool? checked_in {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]

        public PetBreedType Breed {get; set;}
        public void dogBreed (PetBreedType thisBreed)
        {
            Breed = thisBreed;
        }
        public PetBreedType getbreed ()
        {
            return Breed;
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]

        public PetColorType Color {get; set;}
        public void dogColor (PetColorType thisColor)
        {
            Color = thisColor;
        }
        public PetColorType getcolor ()
        {
            return Color;
        }
        [ForeignKey("OwnedBy")]
        public int OwnedById {get; set;} 

        public PetOwner OwnedBy {get; set;}
    }
}
