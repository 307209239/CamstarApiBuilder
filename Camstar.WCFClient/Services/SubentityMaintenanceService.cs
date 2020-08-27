// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SubentityMaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SubentityMaintenanceService : MaintenanceBase
  {
    public SubentityMaintenanceService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISubentityMaintenanceService), userProfile);
    }

    public ResultStatus Delete(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).Delete(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Delete(SubentityMaintenance subentityMaintenance)
    {
      return this.Delete(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Delete(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.Delete(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).Freeze(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Freeze(SubentityMaintenance subentityMaintenance)
    {
      return this.Freeze(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Freeze(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.Freeze(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).GetWIPMsgs(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(SubentityMaintenance subentityMaintenance)
    {
      return this.GetWIPMsgs(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.GetWIPMsgs(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).Load(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Load(SubentityMaintenance subentityMaintenance)
    {
      return this.Load(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus Load(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.Load(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_LoadESigDetails_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).LoadESigDetails(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.LoadESigDetails, (SubentityMaintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SubentityMaintenance) null, (SubentityMaintenance_LoadESigDetails_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus LoadESigDetails(SubentityMaintenance subentityMaintenance)
    {
      return this.LoadESigDetails(subentityMaintenance, (SubentityMaintenance_LoadESigDetails_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus LoadESigDetails(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.LoadESigDetails(subentityMaintenance, (SubentityMaintenance_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).New(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus New(SubentityMaintenance subentityMaintenance)
    {
      return this.New(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus New(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.New(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).NewCopy(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus NewCopy(SubentityMaintenance subentityMaintenance)
    {
      return this.NewCopy(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus NewCopy(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.NewCopy(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).SaveAs(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus SaveAs(SubentityMaintenance subentityMaintenance)
    {
      return this.SaveAs(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus SaveAs(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.SaveAs(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).UnFreeze(this._UserProfile, subentityMaintenance, parameters, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(subentityMaintenance, SubentityMaintenanceMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) subentityMaintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SubentityMaintenance) null, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus UnFreeze(SubentityMaintenance subentityMaintenance)
    {
      return this.UnFreeze(subentityMaintenance, (SubentityMaintenance_Parameters) null, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus UnFreeze(
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.UnFreeze(subentityMaintenance, (SubentityMaintenance_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.Delete((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.Freeze((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_LoadESigDetails_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.New((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.NewCopy((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.SaveAs((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.Load((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject subentityMaintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubentityMaintenance_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SubentityMaintenance) subentityMaintenance, (SubentityMaintenance_Parameters) parameters, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      try
      {
        SubentityMaintenanceMethod[] methods = new SubentityMaintenanceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISubentityMaintenanceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubentityMaintenance cdo,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      try
      {
        return ((ISubentityMaintenanceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SubentityMaintenance_Result result1;
        ResultStatus environment = this.GetEnvironment((SubentityMaintenance) cdo, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.GetEnvironment((SubentityMaintenance) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SubentityMaintenance cdo,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      result = (SubentityMaintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubentityMaintenanceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SubentityMaintenanceMethod(cdo, SubentityMaintenanceMethods.ExecuteTransaction, (SubentityMaintenance_Parameters) null));
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
        SubentityMaintenance_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SubentityMaintenance) cdo, (SubentityMaintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SubentityMaintenance cdo)
    {
      return this.ExecuteTransaction(cdo, (SubentityMaintenance_Request) null, out SubentityMaintenance_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result)
    {
      return this.ExecuteTransaction((SubentityMaintenance) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SubentityMaintenance cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SubentityMaintenanceMethod(cdo, SubentityMaintenanceMethods.AddDataTransaction, (SubentityMaintenance_Parameters) null));
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
        return this.AddDataTransaction((SubentityMaintenance) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
