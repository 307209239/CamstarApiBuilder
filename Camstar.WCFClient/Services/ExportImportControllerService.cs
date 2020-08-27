// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportImportControllerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportImportControllerService : ExportImportTxnsBase
  {
    public ExportImportControllerService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportImportControllerService), userProfile);
    }

    public ResultStatus DeleteExportFile(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (DeleteExportFile), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).DeleteExportFile(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.DeleteExportFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteExportFile), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteExportFile()
    {
      return this.DeleteExportFile((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus DeleteExportFile(ExportImportController exportImportController)
    {
      return this.DeleteExportFile(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus DeleteExportFile(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.DeleteExportFile(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus DeleteImportContent(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (DeleteImportContent), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).DeleteImportContent(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.DeleteImportContent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteImportContent), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteImportContent()
    {
      return this.DeleteImportContent((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus DeleteImportContent(
      ExportImportController exportImportController)
    {
      return this.DeleteImportContent(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus DeleteImportContent(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.DeleteImportContent(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus GenerateExportFile(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (GenerateExportFile), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).GenerateExportFile(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.GenerateExportFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GenerateExportFile), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GenerateExportFile()
    {
      return this.GenerateExportFile((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GenerateExportFile(ExportImportController exportImportController)
    {
      return this.GenerateExportFile(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GenerateExportFile(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.GenerateExportFile(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus GetExportFile(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (GetExportFile), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).GetExportFile(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.GetExportFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetExportFile), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetExportFile()
    {
      return this.GetExportFile((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GetExportFile(ExportImportController exportImportController)
    {
      return this.GetExportFile(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GetExportFile(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.GetExportFile(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).GetWIPMsgs(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GetWIPMsgs(ExportImportController exportImportController)
    {
      return this.GetWIPMsgs(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.GetWIPMsgs(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).Load(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus Load(ExportImportController exportImportController)
    {
      return this.Load(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus Load(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.Load(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus RestartProcess(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (RestartProcess), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).RestartProcess(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.RestartProcess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RestartProcess), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RestartProcess()
    {
      return this.RestartProcess((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus RestartProcess(ExportImportController exportImportController)
    {
      return this.RestartProcess(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus RestartProcess(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.RestartProcess(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus ResumeProcess(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (ResumeProcess), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).ResumeProcess(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.ResumeProcess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResumeProcess), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResumeProcess()
    {
      return this.ResumeProcess((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus ResumeProcess(ExportImportController exportImportController)
    {
      return this.ResumeProcess(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus ResumeProcess(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.ResumeProcess(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus SetImportFile(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (SetImportFile), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).SetImportFile(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.SetImportFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetImportFile), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetImportFile()
    {
      return this.SetImportFile((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus SetImportFile(ExportImportController exportImportController)
    {
      return this.SetImportFile(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus SetImportFile(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.SetImportFile(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    public ResultStatus StopProcess(
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (StopProcess), (DCObject) exportImportController, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).StopProcess(this._UserProfile, exportImportController, parameters, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(exportImportController, ExportImportControllerMethods.StopProcess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StopProcess), res, (DCObject) exportImportController, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StopProcess()
    {
      return this.StopProcess((ExportImportController) null, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus StopProcess(ExportImportController exportImportController)
    {
      return this.StopProcess(exportImportController, (ExportImportController_Parameters) null, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus StopProcess(
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.StopProcess(exportImportController, (ExportImportController_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject exportImportController,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportController_Result result1;
        ResultStatus resultStatus = this.Load((ExportImportController) exportImportController, (ExportImportController_Parameters) parameters, (ExportImportController_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject exportImportController,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportController_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ExportImportController) exportImportController, (ExportImportController_Parameters) parameters, (ExportImportController_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      try
      {
        ExportImportControllerMethod[] methods = new ExportImportControllerMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportImportControllerService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportController_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ExportImportController_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportController cdo,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      try
      {
        return ((IExportImportControllerService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportController_Result result1;
        ResultStatus environment = this.GetEnvironment((ExportImportController) cdo, (ExportImportController_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.GetEnvironment((ExportImportController) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportController cdo,
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      result = (ExportImportController_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportImportControllerService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportImportControllerMethod(cdo, ExportImportControllerMethods.ExecuteTransaction, (ExportImportController_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ExportImportController_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ExportImportController) cdo, (ExportImportController_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ExportImportController cdo)
    {
      return this.ExecuteTransaction(cdo, (ExportImportController_Request) null, out ExportImportController_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ExportImportController_Request request,
      out ExportImportController_Result result)
    {
      return this.ExecuteTransaction((ExportImportController) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ExportImportController cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportImportControllerMethod(cdo, ExportImportControllerMethods.AddDataTransaction, (ExportImportController_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ExportImportController) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
