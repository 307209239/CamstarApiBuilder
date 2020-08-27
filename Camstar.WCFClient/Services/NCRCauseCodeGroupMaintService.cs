// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRCauseCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRCauseCodeGroupMaintService : UserCodeGroupMaintBase
  {
    public NCRCauseCodeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRCauseCodeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).Delete(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.Delete(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.Delete(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).Freeze(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.Freeze(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.Freeze(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.GetWIPMsgs(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).Load(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Load(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.Load(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.Load(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_LoadESigDetails_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.LoadESigDetails, (NCRCauseCodeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.LoadESigDetails(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.LoadESigDetails(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).New(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus New(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.New(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.New(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).NewCopy(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.NewCopy(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.NewCopy(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).SaveAs(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.SaveAs(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.SaveAs(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Parameters parameters,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, nCRCauseCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(nCRCauseCodeGroupMaint, NCRCauseCodeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRCauseCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRCauseCodeGroupMaint) null, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint)
    {
      return this.UnFreeze(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRCauseCodeGroupMaint nCRCauseCodeGroupMaint,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.UnFreeze(nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_LoadESigDetails_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRCauseCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRCauseCodeGroupMaint) nCRCauseCodeGroupMaint, (NCRCauseCodeGroupMaint_Parameters) parameters, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      try
      {
        NCRCauseCodeGroupMaintMethod[] methods = new NCRCauseCodeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRCauseCodeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCauseCodeGroupMaint cdo,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      try
      {
        return ((INCRCauseCodeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRCauseCodeGroupMaint) cdo, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.GetEnvironment((NCRCauseCodeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRCauseCodeGroupMaint cdo,
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      result = (NCRCauseCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(cdo, NCRCauseCodeGroupMaintMethods.ExecuteTransaction, (NCRCauseCodeGroupMaint_Parameters) null));
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
        NCRCauseCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRCauseCodeGroupMaint) cdo, (NCRCauseCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRCauseCodeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRCauseCodeGroupMaint_Request) null, out NCRCauseCodeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRCauseCodeGroupMaint_Request request,
      out NCRCauseCodeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((NCRCauseCodeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRCauseCodeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRCauseCodeGroupMaintMethod(cdo, NCRCauseCodeGroupMaintMethods.AddDataTransaction, (NCRCauseCodeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRCauseCodeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
