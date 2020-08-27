// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceClassMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintenanceClassMaintService : NamedDataObjectMaintBase
  {
    public MaintenanceClassMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintenanceClassMaintService), userProfile);
    }

    public ResultStatus Delete(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).Delete(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Delete(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.Delete(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Delete(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.Delete(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).Freeze(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Freeze(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.Freeze(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Freeze(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.Freeze(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).GetWIPMsgs(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.GetWIPMsgs(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.GetWIPMsgs(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).Load(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Load(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.Load(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus Load(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.Load(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_LoadESigDetails_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).LoadESigDetails(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.LoadESigDetails, (MaintenanceClassMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintenanceClassMaint) null, (MaintenanceClassMaint_LoadESigDetails_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.LoadESigDetails(maintenanceClassMaint, (MaintenanceClassMaint_LoadESigDetails_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.LoadESigDetails(maintenanceClassMaint, (MaintenanceClassMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).New(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus New(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.New(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus New(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.New(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).NewCopy(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus NewCopy(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.NewCopy(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus NewCopy(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.NewCopy(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).SaveAs(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus SaveAs(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.SaveAs(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus SaveAs(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.SaveAs(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).UnFreeze(this._UserProfile, maintenanceClassMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(maintenanceClassMaint, MaintenanceClassMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) maintenanceClassMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MaintenanceClassMaint) null, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus UnFreeze(MaintenanceClassMaint maintenanceClassMaint)
    {
      return this.UnFreeze(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.UnFreeze(maintenanceClassMaint, (MaintenanceClassMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_LoadESigDetails_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.New((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.Load((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintenanceClassMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceClassMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintenanceClassMaint) maintenanceClassMaint, (MaintenanceClassMaint_Parameters) parameters, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      try
      {
        MaintenanceClassMaintMethod[] methods = new MaintenanceClassMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintenanceClassMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceClassMaint cdo,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      try
      {
        return ((IMaintenanceClassMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintenanceClassMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintenanceClassMaint) cdo, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.GetEnvironment((MaintenanceClassMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceClassMaint cdo,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      result = (MaintenanceClassMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceClassMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintenanceClassMaintMethod(cdo, MaintenanceClassMaintMethods.ExecuteTransaction, (MaintenanceClassMaint_Parameters) null));
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
        MaintenanceClassMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintenanceClassMaint) cdo, (MaintenanceClassMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintenanceClassMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintenanceClassMaint_Request) null, out MaintenanceClassMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result)
    {
      return this.ExecuteTransaction((MaintenanceClassMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintenanceClassMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintenanceClassMaintMethod(cdo, MaintenanceClassMaintMethods.AddDataTransaction, (MaintenanceClassMaint_Parameters) null));
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
        return this.AddDataTransaction((MaintenanceClassMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
