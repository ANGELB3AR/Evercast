﻿namespace AC
{

	public class EventOptionsLanguage : EventBase
	{


		public override string[] EditorNames { get { return new string[] { "Options/Change language" }; } }
		protected override string EventName { get { return "OnChangeLanguage"; } }
		protected override string ConditionHelp { get { return "Whenever the language is set."; } }


		public override void Register ()
		{
			EventManager.OnChangeLanguage += OnChangeLanguage;
		}


		public override void Unregister ()
		{
			EventManager.OnChangeLanguage -= OnChangeLanguage;
		}


		private void OnChangeLanguage (int languageIndex)
		{
			Run (new object[] { languageIndex });
		}


		protected override ParameterReference[] GetParameterReferences ()
		{
			return new ParameterReference[]
			{
				new ParameterReference (ParameterType.Integer, "Language"),
			};
		}


#if UNITY_EDITOR

		protected override bool HasConditions (bool isAssetFile) { return false; }

#endif

	}

}