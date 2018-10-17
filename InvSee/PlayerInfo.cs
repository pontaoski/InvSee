﻿using TShockAPI;

namespace InvSee
{
	public class PlayerInfo
	{
		public const string KEY = "InvSee_Data";

		public PlayerData Backup { get; set; }
        
		public int CopyingUserID { get; set; }
        public int CopyingPlayerIndex { get; set; }

        public PlayerInfo()
		{
			Backup = null;
            CopyingUserID = CopyingPlayerIndex = -1;
		}

		public bool Restore(TSPlayer player)
		{
            if (Backup == null) { return false; }
			Backup.RestoreCharacter(player);
			Backup = null;
            CopyingUserID = CopyingPlayerIndex = -1;
            return true;
		}
	}
}