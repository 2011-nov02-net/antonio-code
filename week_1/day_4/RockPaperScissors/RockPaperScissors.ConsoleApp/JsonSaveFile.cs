using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;


namespace RockPaperScissors.Library
{

    class JsonSaveFile
    {
        private readonly string _filePath;

        public JsonSaveFile(string filePath)
        {
            _filePath = filePath;
        }

        public GameManager Read()
        {
            string json = File.ReadAllText(_filePath);
            try
            {
                GameManager data = JsonSerializer.Deserialize<GameManager>(json);
            }
            GameManager data = JsonSerializer.Deserialize<GameManager>(json);
            return data;
        }

        public void Write(GameManager data)
        {
            string json = JsonSerializer.Serialize(data.GetMatches());
            File.WriteAllText(_filePath, json);
        }
    }

    }
