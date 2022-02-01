using PianoKeyboard;

Key a = new Key(Note.A, Accidental.Sharp, Octave.First);
Key b = new Key(Note.B, Accidental.Flat, Octave.Fifth);

Console.WriteLine(a);
Console.WriteLine(b);
Console.Write("IsEnharmonic: ");
Console.Write(a.Equals(b));
Console.WriteLine();
Console.WriteLine(a.CompareTo(b));
Console.WriteLine();