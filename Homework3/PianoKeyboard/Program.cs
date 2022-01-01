using PianoKeyboard;

Key c = new Key(Note.C, Accidentall.Sharp, Octave.First);
Console.WriteLine(c);

Key d = new Key(Note.C, Accidentall.Sharp, Octave.Fifth);

Console.WriteLine(c.Equals(d));
