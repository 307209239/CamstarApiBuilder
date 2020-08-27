// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScaleGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScaleGroupMaintService : ResourceGroupMaintBase
  {
    public ScaleGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScaleGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).Delete(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Delete(ScaleGroupMaint scaleGroupMaint)
    {
      return this.Delete(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.Delete(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).Freeze(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Freeze(ScaleGroupMaint scaleGroupMaint)
    {
      return this.Freeze(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.Freeze(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScaleGroupMaint scaleGroupMaint)
    {
      return this.GetWIPMsgs(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.GetWIPMsgs(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).Load(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Load(ScaleGroupMaint scaleGroupMaint)
    {
      return this.Load(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus Load(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.Load(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_LoadESigDetails_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.LoadESigDetails, (ScaleGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScaleGroupMaint) null, (ScaleGroupMaint_LoadESigDetails_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScaleGroupMaint scaleGroupMaint)
    {
      return this.LoadESigDetails(scaleGroupMaint, (ScaleGroupMaint_LoadESigDetails_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.LoadESigDetails(scaleGroupMaint, (ScaleGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).New(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus New(ScaleGroupMaint scaleGroupMaint)
    {
      return this.New(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus New(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.New(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).NewCopy(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ScaleGroupMaint scaleGroupMaint)
    {
      return this.NewCopy(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.NewCopy(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).SaveAs(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ScaleGroupMaint scaleGroupMaint)
    {
      return this.SaveAs(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.SaveAs(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Parameters parameters,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).UnFreeze(this._UserProfile, scaleGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(scaleGroupMaint, ScaleGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scaleGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScaleGroupMaint) null, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ScaleGroupMaint scaleGroupMaint)
    {
      return this.UnFreeze(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScaleGroupMaint scaleGroupMaint,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.UnFreeze(scaleGroupMaint, (ScaleGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_LoadESigDetails_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scaleGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScaleGroupMaint) scaleGroupMaint, (ScaleGroupMaint_Parameters) parameters, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      try
      {
        ScaleGroupMaintMethod[] methods = new ScaleGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScaleGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleGroupMaint cdo,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      try
      {
        return ((IScaleGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScaleGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScaleGroupMaint) cdo, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.GetEnvironment((ScaleGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScaleGroupMaint cdo,
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      result = (ScaleGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScaleGroupMaintMethod(cdo, ScaleGroupMaintMethods.ExecuteTransaction, (ScaleGroupMaint_Parameters) null));
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
        ScaleGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScaleGroupMaint) cdo, (ScaleGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScaleGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScaleGroupMaint_Request) null, out ScaleGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScaleGroupMaint_Request request,
      out ScaleGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ScaleGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScaleGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScaleGroupMaintMethod(cdo, ScaleGroupMaintMethods.AddDataTransaction, (ScaleGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ScaleGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
