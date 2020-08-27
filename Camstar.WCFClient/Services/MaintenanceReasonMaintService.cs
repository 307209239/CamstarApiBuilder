// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintenanceReasonMaintService : UserCodeMaintBase
  {
    public MaintenanceReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintenanceReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).Delete(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Delete(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.Delete(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Delete(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.Delete(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).Freeze(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Freeze(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.Freeze(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.Freeze(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.GetWIPMsgs(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.GetWIPMsgs(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).Load(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Load(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.Load(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus Load(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.Load(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_LoadESigDetails_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.LoadESigDetails, (MaintenanceReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_LoadESigDetails_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.LoadESigDetails(maintenanceReasonMaint, (MaintenanceReasonMaint_LoadESigDetails_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.LoadESigDetails(maintenanceReasonMaint, (MaintenanceReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).New(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus New(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.New(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus New(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.New(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).NewCopy(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.NewCopy(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.NewCopy(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).SaveAs(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.SaveAs(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.SaveAs(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).UnFreeze(this._UserProfile, maintenanceReasonMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(maintenanceReasonMaint, MaintenanceReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) maintenanceReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MaintenanceReasonMaint) null, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(MaintenanceReasonMaint maintenanceReasonMaint)
    {
      return this.UnFreeze(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.UnFreeze(maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_LoadESigDetails_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintenanceReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintenanceReasonMaint) maintenanceReasonMaint, (MaintenanceReasonMaint_Parameters) parameters, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      try
      {
        MaintenanceReasonMaintMethod[] methods = new MaintenanceReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintenanceReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReasonMaint cdo,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      try
      {
        return ((IMaintenanceReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintenanceReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintenanceReasonMaint) cdo, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.GetEnvironment((MaintenanceReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReasonMaint cdo,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      result = (MaintenanceReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintenanceReasonMaintMethod(cdo, MaintenanceReasonMaintMethods.ExecuteTransaction, (MaintenanceReasonMaint_Parameters) null));
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
        MaintenanceReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintenanceReasonMaint) cdo, (MaintenanceReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintenanceReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintenanceReasonMaint_Request) null, out MaintenanceReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result)
    {
      return this.ExecuteTransaction((MaintenanceReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintenanceReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintenanceReasonMaintMethod(cdo, MaintenanceReasonMaintMethods.AddDataTransaction, (MaintenanceReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((MaintenanceReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
