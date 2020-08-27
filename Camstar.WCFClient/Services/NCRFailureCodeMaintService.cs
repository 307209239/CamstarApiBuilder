// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRFailureCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRFailureCodeMaintService : UserCodeMaintBase
  {
    public NCRFailureCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRFailureCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).Delete(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Delete(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.Delete(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Delete(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.Delete(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).Freeze(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Freeze(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.Freeze(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.Freeze(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.GetWIPMsgs(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.GetWIPMsgs(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).Load(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Load(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.Load(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus Load(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.Load(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_LoadESigDetails_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.LoadESigDetails, (NCRFailureCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_LoadESigDetails_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.LoadESigDetails(nCRFailureCodeMaint, (NCRFailureCodeMaint_LoadESigDetails_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.LoadESigDetails(nCRFailureCodeMaint, (NCRFailureCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).New(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus New(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.New(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus New(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.New(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).NewCopy(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus NewCopy(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.NewCopy(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.NewCopy(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).SaveAs(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus SaveAs(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.SaveAs(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.SaveAs(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).UnFreeze(this._UserProfile, nCRFailureCodeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(nCRFailureCodeMaint, NCRFailureCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRFailureCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRFailureCodeMaint) null, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRFailureCodeMaint nCRFailureCodeMaint)
    {
      return this.UnFreeze(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.UnFreeze(nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_LoadESigDetails_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRFailureCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRFailureCodeMaint) nCRFailureCodeMaint, (NCRFailureCodeMaint_Parameters) parameters, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      try
      {
        NCRFailureCodeMaintMethod[] methods = new NCRFailureCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRFailureCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureCodeMaint cdo,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      try
      {
        return ((INCRFailureCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRFailureCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRFailureCodeMaint) cdo, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.GetEnvironment((NCRFailureCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureCodeMaint cdo,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      result = (NCRFailureCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRFailureCodeMaintMethod(cdo, NCRFailureCodeMaintMethods.ExecuteTransaction, (NCRFailureCodeMaint_Parameters) null));
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
        NCRFailureCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRFailureCodeMaint) cdo, (NCRFailureCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRFailureCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRFailureCodeMaint_Request) null, out NCRFailureCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result)
    {
      return this.ExecuteTransaction((NCRFailureCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRFailureCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRFailureCodeMaintMethod(cdo, NCRFailureCodeMaintMethods.AddDataTransaction, (NCRFailureCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRFailureCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
