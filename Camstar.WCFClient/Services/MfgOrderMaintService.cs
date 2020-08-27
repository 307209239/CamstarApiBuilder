// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgOrderMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MfgOrderMaintService : NamedDataObjectMaintBase
  {
    public MfgOrderMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMfgOrderMaintService), userProfile);
    }

    public ResultStatus Delete(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).Delete(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Delete(MfgOrderMaint mfgOrderMaint)
    {
      return this.Delete(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Delete(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.Delete(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).Freeze(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Freeze(MfgOrderMaint mfgOrderMaint)
    {
      return this.Freeze(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Freeze(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.Freeze(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).GetWIPMsgs(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MfgOrderMaint mfgOrderMaint)
    {
      return this.GetWIPMsgs(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.GetWIPMsgs(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).Load(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Load(MfgOrderMaint mfgOrderMaint)
    {
      return this.Load(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus Load(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.Load(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_LoadESigDetails_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).LoadESigDetails(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.LoadESigDetails, (MfgOrderMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MfgOrderMaint) null, (MfgOrderMaint_LoadESigDetails_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MfgOrderMaint mfgOrderMaint)
    {
      return this.LoadESigDetails(mfgOrderMaint, (MfgOrderMaint_LoadESigDetails_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.LoadESigDetails(mfgOrderMaint, (MfgOrderMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).New(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus New(MfgOrderMaint mfgOrderMaint)
    {
      return this.New(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus New(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.New(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).NewCopy(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus NewCopy(MfgOrderMaint mfgOrderMaint)
    {
      return this.NewCopy(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus NewCopy(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.NewCopy(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).SaveAs(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus SaveAs(MfgOrderMaint mfgOrderMaint)
    {
      return this.SaveAs(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus SaveAs(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.SaveAs(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Parameters parameters,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).UnFreeze(this._UserProfile, mfgOrderMaint, parameters, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(mfgOrderMaint, MfgOrderMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) mfgOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MfgOrderMaint) null, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus UnFreeze(MfgOrderMaint mfgOrderMaint)
    {
      return this.UnFreeze(mfgOrderMaint, (MfgOrderMaint_Parameters) null, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MfgOrderMaint mfgOrderMaint,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.UnFreeze(mfgOrderMaint, (MfgOrderMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_LoadESigDetails_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.New((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.Load((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject mfgOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgOrderMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MfgOrderMaint) mfgOrderMaint, (MfgOrderMaint_Parameters) parameters, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      try
      {
        MfgOrderMaintMethod[] methods = new MfgOrderMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMfgOrderMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgOrderMaint cdo,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      try
      {
        return ((IMfgOrderMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MfgOrderMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MfgOrderMaint) cdo, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.GetEnvironment((MfgOrderMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MfgOrderMaint cdo,
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      result = (MfgOrderMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgOrderMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MfgOrderMaintMethod(cdo, MfgOrderMaintMethods.ExecuteTransaction, (MfgOrderMaint_Parameters) null));
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
        MfgOrderMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MfgOrderMaint) cdo, (MfgOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MfgOrderMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MfgOrderMaint_Request) null, out MfgOrderMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MfgOrderMaint_Request request,
      out MfgOrderMaint_Result result)
    {
      return this.ExecuteTransaction((MfgOrderMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MfgOrderMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MfgOrderMaintMethod(cdo, MfgOrderMaintMethods.AddDataTransaction, (MfgOrderMaint_Parameters) null));
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
        return this.AddDataTransaction((MfgOrderMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
