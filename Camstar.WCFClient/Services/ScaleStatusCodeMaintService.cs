// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScaleStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScaleStatusCodeMaintService : ResourceStatusCodeMaintBase
  {
    public ScaleStatusCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScaleStatusCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).Delete(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.Delete(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.Delete(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).Freeze(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.Freeze(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.Freeze(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.GetWIPMsgs(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.GetWIPMsgs(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).Load(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Load(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.Load(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus Load(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.Load(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_LoadESigDetails_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.LoadESigDetails, (ScaleStatusCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_LoadESigDetails_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.LoadESigDetails(scaleStatusCodeMaint, (ScaleStatusCodeMaint_LoadESigDetails_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.LoadESigDetails(scaleStatusCodeMaint, (ScaleStatusCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).New(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus New(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.New(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus New(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.New(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).NewCopy(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.NewCopy(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.NewCopy(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).SaveAs(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.SaveAs(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.SaveAs(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Parameters parameters,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).UnFreeze(this._UserProfile, scaleStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(scaleStatusCodeMaint, ScaleStatusCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scaleStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScaleStatusCodeMaint) null, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(ScaleStatusCodeMaint scaleStatusCodeMaint)
    {
      return this.UnFreeze(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScaleStatusCodeMaint scaleStatusCodeMaint,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.UnFreeze(scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_LoadESigDetails_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scaleStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScaleStatusCodeMaint) scaleStatusCodeMaint, (ScaleStatusCodeMaint_Parameters) parameters, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      try
      {
        ScaleStatusCodeMaintMethod[] methods = new ScaleStatusCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScaleStatusCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleStatusCodeMaint cdo,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      try
      {
        return ((IScaleStatusCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScaleStatusCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScaleStatusCodeMaint) cdo, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.GetEnvironment((ScaleStatusCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScaleStatusCodeMaint cdo,
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      result = (ScaleStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(cdo, ScaleStatusCodeMaintMethods.ExecuteTransaction, (ScaleStatusCodeMaint_Parameters) null));
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
        ScaleStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScaleStatusCodeMaint) cdo, (ScaleStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScaleStatusCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScaleStatusCodeMaint_Request) null, out ScaleStatusCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScaleStatusCodeMaint_Request request,
      out ScaleStatusCodeMaint_Result result)
    {
      return this.ExecuteTransaction((ScaleStatusCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScaleStatusCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScaleStatusCodeMaintMethod(cdo, ScaleStatusCodeMaintMethods.AddDataTransaction, (ScaleStatusCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((ScaleStatusCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
