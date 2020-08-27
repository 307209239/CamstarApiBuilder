// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRFailureTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRFailureTypeMaintService : UserCodeMaintBase
  {
    public NCRFailureTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRFailureTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).Delete(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Delete(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.Delete(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Delete(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.Delete(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).Freeze(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Freeze(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.Freeze(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.Freeze(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.GetWIPMsgs(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.GetWIPMsgs(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).Load(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Load(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.Load(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus Load(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.Load(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_LoadESigDetails_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.LoadESigDetails, (NCRFailureTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_LoadESigDetails_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.LoadESigDetails(nCRFailureTypeMaint, (NCRFailureTypeMaint_LoadESigDetails_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.LoadESigDetails(nCRFailureTypeMaint, (NCRFailureTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).New(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus New(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.New(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus New(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.New(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).NewCopy(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus NewCopy(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.NewCopy(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.NewCopy(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).SaveAs(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus SaveAs(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.SaveAs(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.SaveAs(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Parameters parameters,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).UnFreeze(this._UserProfile, nCRFailureTypeMaint, parameters, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(nCRFailureTypeMaint, NCRFailureTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) nCRFailureTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NCRFailureTypeMaint) null, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(NCRFailureTypeMaint nCRFailureTypeMaint)
    {
      return this.UnFreeze(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NCRFailureTypeMaint nCRFailureTypeMaint,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.UnFreeze(nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_LoadESigDetails_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRFailureTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRFailureTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRFailureTypeMaint) nCRFailureTypeMaint, (NCRFailureTypeMaint_Parameters) parameters, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      try
      {
        NCRFailureTypeMaintMethod[] methods = new NCRFailureTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRFailureTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureTypeMaint cdo,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      try
      {
        return ((INCRFailureTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRFailureTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRFailureTypeMaint) cdo, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.GetEnvironment((NCRFailureTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureTypeMaint cdo,
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      result = (NCRFailureTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRFailureTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRFailureTypeMaintMethod(cdo, NCRFailureTypeMaintMethods.ExecuteTransaction, (NCRFailureTypeMaint_Parameters) null));
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
        NCRFailureTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRFailureTypeMaint) cdo, (NCRFailureTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRFailureTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRFailureTypeMaint_Request) null, out NCRFailureTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRFailureTypeMaint_Request request,
      out NCRFailureTypeMaint_Result result)
    {
      return this.ExecuteTransaction((NCRFailureTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRFailureTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRFailureTypeMaintMethod(cdo, NCRFailureTypeMaintMethods.AddDataTransaction, (NCRFailureTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((NCRFailureTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
