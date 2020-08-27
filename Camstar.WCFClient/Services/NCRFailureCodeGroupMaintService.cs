// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRFailureCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRFailureCodeGroupMaintService : UserCodeGroupMaintBase
  {
    public NCRFailureCodeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRFailureCodeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).Delete(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.Delete(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.Delete(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).Freeze(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.Freeze(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.Freeze(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.GetWIPMsgs(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).Load(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Load(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.Load(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.Load(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_LoadESigDetails_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.LoadESigDetails, (NCRFailureCodeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.LoadESigDetails(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_LoadESigDetails_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.LoadESigDetails(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).New(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus New(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.New(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.New(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).NewCopy(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.NewCopy(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.NewCopy(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).SaveAs(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.SaveAs(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.SaveAs(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, nCRFailureCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(nCRFailureCodeGroupMaint, NCRFailureCodeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRFailureCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRFailureCodeGroupMaint) null, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint)
    {
      return this.UnFreeze(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.UnFreeze(nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_LoadESigDetails_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRFailureCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRFailureCodeGroupMaint) nCRFailureCodeGroupMaint, (NCRFailureCodeGroupMaint_Parameters) parameters, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      try
      {
        NCRFailureCodeGroupMaintMethod[] methods = new NCRFailureCodeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRFailureCodeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureCodeGroupMaint cdo,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      try
      {
        return ((INCRFailureCodeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRFailureCodeGroupMaint) cdo, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.GetEnvironment((NCRFailureCodeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureCodeGroupMaint cdo,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      result = (NCRFailureCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(cdo, NCRFailureCodeGroupMaintMethods.ExecuteTransaction, (NCRFailureCodeGroupMaint_Parameters) null));
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
        NCRFailureCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRFailureCodeGroupMaint) cdo, (NCRFailureCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRFailureCodeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRFailureCodeGroupMaint_Request) null, out NCRFailureCodeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((NCRFailureCodeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRFailureCodeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRFailureCodeGroupMaintMethod(cdo, NCRFailureCodeGroupMaintMethods.AddDataTransaction, (NCRFailureCodeGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRFailureCodeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
