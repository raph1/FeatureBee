﻿namespace FeatureBee.Server.Domain.ApplicationServices
{
    public class DeleteFeatureCommand : ICommand
    {
        public DeleteFeatureCommand(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}