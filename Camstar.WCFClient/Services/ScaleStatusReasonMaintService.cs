// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScaleStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScaleStatusReasonMaintService : ResourceStatusReasonMaintBase
  {
    public ScaleStatusReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScaleStatusReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).Delete(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.Delete(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.Delete(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).Freeze(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.Freeze(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.Freeze(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.GetWIPMsgs(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.GetWIPMsgs(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).Load(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Load(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.Load(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus Load(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.Load(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_LoadESigDetails_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.LoadESigDetails, (ScaleStatusReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_LoadESigDetails_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.LoadESigDetails(scaleStatusReasonMaint, (ScaleStatusReasonMaint_LoadESigDetails_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.LoadESigDetails(scaleStatusReasonMaint, (ScaleStatusReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).New(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus New(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.New(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus New(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.New(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).NewCopy(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.NewCopy(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.NewCopy(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).SaveAs(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.SaveAs(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.SaveAs(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).UnFreeze(this._UserProfile, scaleStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(scaleStatusReasonMaint, ScaleStatusReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scaleStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScaleStatusReasonMaint) null, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ScaleStatusReasonMaint scaleStatusReasonMaint)
    {
      return this.UnFreeze(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.UnFreeze(scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_LoadESigDetails_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scaleStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleStatusReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScaleStatusReasonMaint) scaleStatusReasonMaint, (ScaleStatusReasonMaint_Parameters) parameters, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      try
      {
        ScaleStatusReasonMaintMethod[] methods = new ScaleStatusReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScaleStatusReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleStatusReasonMaint cdo,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      try
      {
        return ((IScaleStatusReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScaleStatusReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScaleStatusReasonMaint) cdo, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.GetEnvironment((ScaleStatusReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScaleStatusReasonMaint cdo,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      result = (ScaleStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleStatusReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(cdo, ScaleStatusReasonMaintMethods.ExecuteTransaction, (ScaleStatusReasonMaint_Parameters) null));
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
        ScaleStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScaleStatusReasonMaint) cdo, (ScaleStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScaleStatusReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScaleStatusReasonMaint_Request) null, out ScaleStatusReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ScaleStatusReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScaleStatusReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScaleStatusReasonMaintMethod(cdo, ScaleStatusReasonMaintMethods.AddDataTransaction, (ScaleStatusReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ScaleStatusReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
