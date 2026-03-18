import { fetchEstadoServidor } from './api.js';

// referencias al DOM
const apiStatusElement = document.getElementById('api-status');
const formEmpleado = document.getElementById('form-empleado');
const tablaEmpleados = document.getElementById('tabla-empleados');
const mensajeVacio = document.getElementById('mensaje-vacio');
const contadorActivos = document.getElementById('contador-activos');
const contadorInactivos = document.getElementById('contador-inactivos');

// array en memoria
let empleados = [];

// verificación de API
async function verificarEstadoServidor() {
    try {
        // llamamos al módulo api.js
        const resultado = await fetchEstadoServidor(); 
        
        // si todo sale OK, actualizamos la UI
        apiStatusElement.textContent = resultado; 
        apiStatusElement.classList.replace('bg-secondary', 'bg-success');

    } catch (error) {
        // Si hay un error tmb informamos
        apiStatusElement.textContent = 'Status: DOWN';
        apiStatusElement.classList.replace('bg-secondary', 'bg-danger');
    }
}

// Ejecutamos la consulta apenas carga la página
verificarEstadoServidor();

// --------- Lógica empleados:

// Event listener para agregar empleado
formEmpleado.addEventListener('submit', (e) => {
    e.preventDefault();
    
    const nombre = document.getElementById('nombre').value.trim();
    const apellido = document.getElementById('apellido').value.trim();
    const estado = document.getElementById('estado').value;

    if (nombre === '' || apellido === '') return;

    const nuevoEmpleado = {
        id: Date.now(),
        nombre: nombre,
        apellido: apellido,
        estado: estado
    };

    empleados.push(nuevoEmpleado);
    formEmpleado.reset();
    actualizarInterfaz();
});

// delegación de eventos para el botón de "Alternar Estado"
tablaEmpleados.addEventListener('click', (e) => {
    if (e.target.classList.contains('btn-cambiar-estado')) {
        const idEmpleado = parseInt(e.target.dataset.id);
        
        const empleado = empleados.find(emp => emp.id === idEmpleado);
        if (empleado) {
            empleado.estado = empleado.estado === 'activo' ? 'inactivo' : 'activo';
            actualizarInterfaz();
        }
    }
});

// Función principal de renderizado
function actualizarInterfaz() {
    tablaEmpleados.innerHTML = '';
    mensajeVacio.style.display = empleados.length === 0 ? 'block' : 'none';

    let cantActivos = 0;
    let cantInactivos = 0;

    empleados.forEach(empleado => {
        if (empleado.estado === 'activo') cantActivos++;
        else cantInactivos++;

        const badgeClass = empleado.estado === 'activo' ? 'bg-success': 'bg-danger';

        const fila = document.createElement('tr');
        fila.innerHTML = `
            <td class="fw-bold">${empleado.nombre}</td>
            <td>${empleado.apellido}</td>
            <td><span class="badge ${badgeClass}">${empleado.estado.toUpperCase()}</span></td>
            <td>
                <button class="btn btn-sm btn-outline-secondary btn-cambiar-estado" data-id="${empleado.id}">
                    Alternar Estado
                </button>
            </td>
        `;
        tablaEmpleados.appendChild(fila);
    });

    contadorActivos.textContent = cantActivos;
    contadorInactivos.textContent = cantInactivos;
}