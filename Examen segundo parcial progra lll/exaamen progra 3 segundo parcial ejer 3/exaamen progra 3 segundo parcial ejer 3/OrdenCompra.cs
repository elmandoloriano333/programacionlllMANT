using exaamen_progra_3_segundo_parcial_ejer_3;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _3roExamen
{
    class OrdenCompra
    {
        private long idOrden;
        private String cliente;
        private Calendar fecha;
        private List<Farmaciaabstracta> listaProductos;

        public OrdenCompra(long idOrden, string cliente)
        {
            this.idOrden = idOrden;
            this.cliente = cliente;
            listaProductos = new List<Farmaciaabstracta>();

        }

        public long getidOrden()
        {
            return idOrden;
        }

        public void setidOrden(long idOrden)
        {
            this.idOrden = idOrden;
        }

        public String getCliente()
        {
            return cliente;
        }

        public void setCliente(String cliente)
        {
            this.cliente = cliente;
        }

        internal void insertarProducto(compuesto tiras)
        {
            throw new NotImplementedException();
        }

        public Calendar getFecha()
        {
            return fecha;
        }

        public void setDateTime(Calendar fecha)
        {
            this.fecha = fecha;
        }

        public List<Farmaciaabstracta> getProductos()
        {
            return listaProductos;
        }

        public void setProductos(List<Farmaciaabstracta> listaproductos)
        {
            this.listaProductos = listaproductos;
        }

        public double getPrecio()
        {

            double precio = 0;
            foreach (Farmaciaabstracta producto in listaProductos)
            {
                precio += producto.getPrecio();
            }

            return precio;
        }

        public void insertarProducto(Farmaciaabstracta combo)
        {
            listaProductos.Add(combo);
        }

        public void eliminarProducto(Farmaciaabstracta combo)
        {
            listaProductos.Remove(combo);
        }

        public void imprimirOrden()
        {

            Console.WriteLine(".....................................nOrden: " + idOrden + "nCliente: " + cliente);
            foreach (Farmaciaabstracta producto in listaProductos)
            {

                Console.WriteLine("{0}               {1}", producto.getNombre(), producto.getPrecio());

            }
            Console.WriteLine("Total: {0} .......................................", getPrecio());
        }
    }
}

