// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRResolutionCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRResolutionCodeGroupMaintService : UserCodeGroupMaintBase
  {
    public NCRResolutionCodeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRResolutionCodeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).Delete(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.Delete(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.Delete(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).Freeze(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.Freeze(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.Freeze(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.GetWIPMsgs(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).Load(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.Load(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.Load(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.LoadESigDetails, (NCRResolutionCodeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.LoadESigDetails(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.LoadESigDetails(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).New(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.New(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.New(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).NewCopy(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.NewCopy(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.NewCopy(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).SaveAs(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.SaveAs(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.SaveAs(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, nCRResolutionCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(nCRResolutionCodeGroupMaint, NCRResolutionCodeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRResolutionCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRResolutionCodeGroupMaint) null, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint)
    {
      return this.UnFreeze(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.UnFreeze(nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRResolutionCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRResolutionCodeGroupMaint) nCRResolutionCodeGroupMaint, (NCRResolutionCodeGroupMaint_Parameters) parameters, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      try
      {
        NCRResolutionCodeGroupMaintMethod[] methods = new NCRResolutionCodeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRResolutionCodeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRResolutionCodeGroupMaint cdo,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      try
      {
        return ((INCRResolutionCodeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRResolutionCodeGroupMaint) cdo, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.GetEnvironment((NCRResolutionCodeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRResolutionCodeGroupMaint cdo,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      result = (NCRResolutionCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(cdo, NCRResolutionCodeGroupMaintMethods.ExecuteTransaction, (NCRResolutionCodeGroupMaint_Parameters) null));
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
        NCRResolutionCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRResolutionCodeGroupMaint) cdo, (NCRResolutionCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRResolutionCodeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRResolutionCodeGroupMaint_Request) null, out NCRResolutionCodeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((NCRResolutionCodeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRResolutionCodeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRResolutionCodeGroupMaintMethod(cdo, NCRResolutionCodeGroupMaintMethods.AddDataTransaction, (NCRResolutionCodeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRResolutionCodeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
