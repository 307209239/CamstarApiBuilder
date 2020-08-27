// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRCauseCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRCauseCodeMaintService : UserCodeMaintBase
  {
    public NCRCauseCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRCauseCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).Delete(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Delete(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.Delete(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Delete(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.Delete(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).Freeze(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Freeze(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.Freeze(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.Freeze(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.GetWIPMsgs(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.GetWIPMsgs(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).Load(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Load(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.Load(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus Load(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.Load(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_LoadESigDetails_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.LoadESigDetails, (NCRCauseCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_LoadESigDetails_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.LoadESigDetails(nCRCauseCodeMaint, (NCRCauseCodeMaint_LoadESigDetails_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.LoadESigDetails(nCRCauseCodeMaint, (NCRCauseCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).New(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus New(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.New(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus New(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.New(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).NewCopy(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus NewCopy(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.NewCopy(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.NewCopy(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).SaveAs(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus SaveAs(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.SaveAs(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.SaveAs(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).UnFreeze(this._UserProfile, nCRCauseCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(nCRCauseCodeMaint, NCRCauseCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRCauseCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRCauseCodeMaint) null, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRCauseCodeMaint nCRCauseCodeMaint)
    {
      return this.UnFreeze(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.UnFreeze(nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_LoadESigDetails_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRCauseCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCauseCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRCauseCodeMaint) nCRCauseCodeMaint, (NCRCauseCodeMaint_Parameters) parameters, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      try
      {
        NCRCauseCodeMaintMethod[] methods = new NCRCauseCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRCauseCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCauseCodeMaint cdo,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      try
      {
        return ((INCRCauseCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRCauseCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRCauseCodeMaint) cdo, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.GetEnvironment((NCRCauseCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRCauseCodeMaint cdo,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      result = (NCRCauseCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCauseCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRCauseCodeMaintMethod(cdo, NCRCauseCodeMaintMethods.ExecuteTransaction, (NCRCauseCodeMaint_Parameters) null));
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
        NCRCauseCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRCauseCodeMaint) cdo, (NCRCauseCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRCauseCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRCauseCodeMaint_Request) null, out NCRCauseCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result)
    {
      return this.ExecuteTransaction((NCRCauseCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRCauseCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRCauseCodeMaintMethod(cdo, NCRCauseCodeMaintMethods.AddDataTransaction, (NCRCauseCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRCauseCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
