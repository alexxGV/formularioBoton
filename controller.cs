
public IActionResult Formulario()
{
    return View();
}

[HttpPost]
public IActionResult Formulario(String nombre, String apellido, String descripcion, int valoracion)
{
    Persona persona = new Persona();
    persona.Nombre = nombre;
    persona.Apellido = apellido;
    persona.Descripcion = descripcion;
    persona.Valoracion = valoracion;

    return RedirectToAction("DatosPersona", persona);
}

public IActionResult DatosPersona(Persona persona)
{
    return View(persona);
}
