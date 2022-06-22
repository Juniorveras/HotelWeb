using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebHotel.ViewModel
{
    public class BookingViewModel
    {
        //Nome Cliente
        [Display(Name ="Nome Cliente : ")]
        [Required(ErrorMessage = "Por Favor campo OBRIGATORIO !")]
        public string CustomerName { get; set; }
        //Endereço Cliente
        [Display(Name = "Endereço Cliente : ")]
        [Required(ErrorMessage = "Por Favor campo OBRIGATORIO !")]
        public string CustomerAddress { get; set; }
        //Telefone Cliente
        [Display(Name = "Telefone Cliente : ")]
        [Required(ErrorMessage = "Por Favor campo OBRIGATORIO !")]
        public int CustomerPhone { get; set; }
        //Entrada
        [Display(Name = "Check-in Cliente (Após 12:00 AM): ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe data de Entrada.")]
        public DateTime BookingFrom { get; set; }
        
        //Saida
        [Display(Name = "Check-out do Cliente (Até 12:00 AM): ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe data de Saida.")]
        public DateTime BookingTo { get; set; }
        //Informações do Quarto
        [Display(Name = "Adm. Quarto : ")]
        [Required(ErrorMessage = "Por Favor campo OBRIGATORIO !")]
        public int AssignRoomId { get; set; }
        //Quantidade de Hospedes
        [Display(Name = "Número Hospedes : ")]
        [Required(ErrorMessage = "Por Favor campo OBRIGATORIO !")]
        public int NumberOfMembers { get; set; }
        public IEnumerable<SelectListItem> ListOfRooms { get; set; }
    }
}