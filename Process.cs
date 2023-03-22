		/// <summary>
		/// IsUserInMatrix. Для BPMN шлюза
		/// </summary>
		/// <param name="context">Контекст процесса</param>
		public virtual object IsUserInMatrix (Context context)
		{
      //Находим все элементы матрицы ответственности в которых участвует текущий юзер по версии процесса (IWorkflowProcess)
			var matrixItems = EleWise.ELMA.Workflow.Managers.WorkflowProcessManager.Instance.GetResponsibilityMatrixItems (EleWise.ELMA.Workflow.Managers.WorkflowProcessManager.GetManager (context.WorkflowInstance.Process.GetType ()).Load (context.WorkflowInstance.Process.Id), PublicAPI.Portal.Security.User.GetCurrentUser ());
			//проверяем, есть ли элементы матрицы с guid ЗО
			return matrixItems.Where (c => c.SwimlaneUid.Value.ToString () == " ТУТ UID ЗОНЫ ОТВЕТСТВЕННОСТИ ").Any ();
    }
