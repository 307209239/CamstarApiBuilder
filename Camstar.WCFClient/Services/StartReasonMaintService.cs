// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StartReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class StartReasonMaintService : UserCodeWithWMMaintBase
  {
    public StartReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IStartReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).Delete(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Delete(StartReasonMaint startReasonMaint)
    {
      return this.Delete(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Delete(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.Delete(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).Freeze(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Freeze(StartReasonMaint startReasonMaint)
    {
      return this.Freeze(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.Freeze(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(StartReasonMaint startReasonMaint)
    {
      return this.GetWIPMsgs(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.GetWIPMsgs(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).Load(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Load(StartReasonMaint startReasonMaint)
    {
      return this.Load(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus Load(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.Load(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_LoadESigDetails_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.LoadESigDetails, (StartReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((StartReasonMaint) null, (StartReasonMaint_LoadESigDetails_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(StartReasonMaint startReasonMaint)
    {
      return this.LoadESigDetails(startReasonMaint, (StartReasonMaint_LoadESigDetails_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.LoadESigDetails(startReasonMaint, (StartReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).New(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus New(StartReasonMaint startReasonMaint)
    {
      return this.New(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus New(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.New(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).NewCopy(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus NewCopy(StartReasonMaint startReasonMaint)
    {
      return this.NewCopy(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.NewCopy(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).SaveAs(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus SaveAs(StartReasonMaint startReasonMaint)
    {
      return this.SaveAs(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.SaveAs(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) startReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).UnFreeze(this._UserProfile, startReasonMaint, parameters, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(startReasonMaint, StartReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) startReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((StartReasonMaint) null, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(StartReasonMaint startReasonMaint)
    {
      return this.UnFreeze(startReasonMaint, (StartReasonMaint_Parameters) null, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.UnFreeze(startReasonMaint, (StartReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((StartReasonMaint) startReasonMaint, (StartReasonMaint_LoadESigDetails_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject startReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((StartReasonMaint) startReasonMaint, (StartReasonMaint_Parameters) parameters, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      try
      {
        StartReasonMaintMethod[] methods = new StartReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IStartReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      StartReasonMaint cdo,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      try
      {
        return ((IStartReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        StartReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((StartReasonMaint) cdo, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.GetEnvironment((StartReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      StartReasonMaint cdo,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      result = (StartReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new StartReasonMaintMethod(cdo, StartReasonMaintMethods.ExecuteTransaction, (StartReasonMaint_Parameters) null));
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
        StartReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((StartReasonMaint) cdo, (StartReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(StartReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (StartReasonMaint_Request) null, out StartReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result)
    {
      return this.ExecuteTransaction((StartReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(StartReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new StartReasonMaintMethod(cdo, StartReasonMaintMethods.AddDataTransaction, (StartReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((StartReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
