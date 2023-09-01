using Agregação;

Professor prof1 = new Professor("Carlos", "Quimica");
Professor prof2 = new Professor("Fernanda", "Portugues");
Professor prof3 = new Professor("Ana", "Fisica");
Professor prof4 = new Professor("Paulo", "Historia");


Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof3);
dep1.ListaProfessores();

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof4);
dep2.ListaProfessores();


Console.ReadKey();



//um relacionamento de agregação é um tipo essencial de composição onde objs de uma classe podem contem um 
//ou mais objs de outra classe

//agregação é uma associação mais fraca
//composição é uma associação forte