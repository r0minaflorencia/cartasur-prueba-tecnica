/**
 * módulo para interactuar con la API externa.
 * Responsabilidad: Realizar peticion HTTP y devolver estado.
 */

const API_URL = 'https://svct.cartasur.com.ar/api/dummy';

export async function fetchEstadoServidor() {
    try {
        // Hacemos la petición al endpoint de prueba
        const respuesta = await fetch(API_URL);
        
        if (!respuesta.ok) {
            throw new Error('Problema de conexión con el servidor');
        }
        
        // Extraemos y devolvemos texto plano
        return await respuesta.text(); 

    } catch (error) {
        console.error('Error consultando la API:', error);
        throw error; // Arrojamos el error para que app.js lo maneje en la UI
    }
}