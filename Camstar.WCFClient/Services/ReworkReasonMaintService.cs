// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReworkReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReworkReasonMaintService : UserCodeWithWMMaintBase
  {
    public ReworkReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReworkReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).Delete(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Delete(ReworkReasonMaint reworkReasonMaint)
    {
      return this.Delete(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.Delete(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).Freeze(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Freeze(ReworkReasonMaint reworkReasonMaint)
    {
      return this.Freeze(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.Freeze(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ReworkReasonMaint reworkReasonMaint)
    {
      return this.GetWIPMsgs(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.GetWIPMsgs(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).Load(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Load(ReworkReasonMaint reworkReasonMaint)
    {
      return this.Load(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus Load(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.Load(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_LoadESigDetails_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.LoadESigDetails, (ReworkReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReworkReasonMaint) null, (ReworkReasonMaint_LoadESigDetails_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ReworkReasonMaint reworkReasonMaint)
    {
      return this.LoadESigDetails(reworkReasonMaint, (ReworkReasonMaint_LoadESigDetails_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.LoadESigDetails(reworkReasonMaint, (ReworkReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).New(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus New(ReworkReasonMaint reworkReasonMaint)
    {
      return this.New(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus New(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.New(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).NewCopy(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ReworkReasonMaint reworkReasonMaint)
    {
      return this.NewCopy(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.NewCopy(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).SaveAs(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ReworkReasonMaint reworkReasonMaint)
    {
      return this.SaveAs(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.SaveAs(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).UnFreeze(this._UserProfile, reworkReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(reworkReasonMaint, ReworkReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) reworkReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReworkReasonMaint) null, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ReworkReasonMaint reworkReasonMaint)
    {
      return this.UnFreeze(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.UnFreeze(reworkReasonMaint, (ReworkReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_LoadESigDetails_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reworkReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReworkReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReworkReasonMaint) reworkReasonMaint, (ReworkReasonMaint_Parameters) parameters, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      try
      {
        ReworkReasonMaintMethod[] methods = new ReworkReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReworkReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReworkReasonMaint cdo,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      try
      {
        return ((IReworkReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReworkReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReworkReasonMaint) cdo, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.GetEnvironment((ReworkReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReworkReasonMaint cdo,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      result = (ReworkReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReworkReasonMaintMethod(cdo, ReworkReasonMaintMethods.ExecuteTransaction, (ReworkReasonMaint_Parameters) null));
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
        ReworkReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReworkReasonMaint) cdo, (ReworkReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReworkReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReworkReasonMaint_Request) null, out ReworkReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ReworkReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReworkReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReworkReasonMaintMethod(cdo, ReworkReasonMaintMethods.AddDataTransaction, (ReworkReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ReworkReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
