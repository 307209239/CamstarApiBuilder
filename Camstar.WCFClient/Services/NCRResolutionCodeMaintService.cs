// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRResolutionCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRResolutionCodeMaintService : UserCodeMaintBase
  {
    public NCRResolutionCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRResolutionCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).Delete(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Delete(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.Delete(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Delete(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.Delete(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).Freeze(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Freeze(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.Freeze(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.Freeze(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.GetWIPMsgs(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.GetWIPMsgs(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).Load(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Load(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.Load(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus Load(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.Load(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_LoadESigDetails_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.LoadESigDetails, (NCRResolutionCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_LoadESigDetails_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.LoadESigDetails(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_LoadESigDetails_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.LoadESigDetails(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).New(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus New(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.New(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus New(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.New(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).NewCopy(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus NewCopy(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.NewCopy(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.NewCopy(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).SaveAs(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus SaveAs(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.SaveAs(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.SaveAs(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Parameters parameters,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).UnFreeze(this._UserProfile, nCRResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(nCRResolutionCodeMaint, NCRResolutionCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRResolutionCodeMaint) null, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRResolutionCodeMaint nCRResolutionCodeMaint)
    {
      return this.UnFreeze(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRResolutionCodeMaint nCRResolutionCodeMaint,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.UnFreeze(nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_LoadESigDetails_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRResolutionCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRResolutionCodeMaint) nCRResolutionCodeMaint, (NCRResolutionCodeMaint_Parameters) parameters, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      try
      {
        NCRResolutionCodeMaintMethod[] methods = new NCRResolutionCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRResolutionCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRResolutionCodeMaint cdo,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      try
      {
        return ((INCRResolutionCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRResolutionCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRResolutionCodeMaint) cdo, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.GetEnvironment((NCRResolutionCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRResolutionCodeMaint cdo,
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      result = (NCRResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRResolutionCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(cdo, NCRResolutionCodeMaintMethods.ExecuteTransaction, (NCRResolutionCodeMaint_Parameters) null));
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
        NCRResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRResolutionCodeMaint) cdo, (NCRResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRResolutionCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRResolutionCodeMaint_Request) null, out NCRResolutionCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRResolutionCodeMaint_Request request,
      out NCRResolutionCodeMaint_Result result)
    {
      return this.ExecuteTransaction((NCRResolutionCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRResolutionCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRResolutionCodeMaintMethod(cdo, NCRResolutionCodeMaintMethods.AddDataTransaction, (NCRResolutionCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRResolutionCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
