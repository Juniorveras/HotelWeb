using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHotel.ViewModel
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        [Display(Name = "Num. do Quarto")]
        [Required(ErrorMessage = "Numero do Quarto é requerido.")]
        public string RoomNumber { get; set; }

        [Display(Name = "Imagem do Quarto")]
        public string RoomImage { get; set; }


        [Display(Name = "Valor Quarto")]
        [Required(ErrorMessage = "Valor do Quarto é requerido.")]
        [Range(100, 10000, ErrorMessage = "O valor do quarto deve estar entre {1} e {2}. ")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Reserva Estatus")]
        [Required(ErrorMessage = "Estatus do Quarto é requerido.")]
        public int BookingStatusId { get; set; }

        [Display(Name = "Tipo do Quarto")]
        [Required(ErrorMessage = "Tipo do Quarto é requerido.")]     
        public int RoomTypeId { get; set; }


        [Display(Name = "Num. de Hospedes")]
        [Required(ErrorMessage = "Hospedes são requeridos.")]
        [Range(1, 8, ErrorMessage = "Capacidade deve ser clara ! {1} a {2}. ")]            
        public int RoomCapacity { get; set; }

        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "Desc. do Quarto")]
        [Required(ErrorMessage = "Descrição do Quarto é requerido.")]
        public string RoomDescription { get; set; }
        public List<SelectListItem> ListOfBookingStatus {get; set;}
        public List<SelectListItem> ListOfRoomType { get; set; }
    }
}