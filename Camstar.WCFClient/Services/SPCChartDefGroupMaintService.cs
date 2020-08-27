// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SPCChartDefGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SPCChartDefGroupMaintService : NamedObjectGroupMaintBase
  {
    public SPCChartDefGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISPCChartDefGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).Delete(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Delete(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.Delete(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Delete(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.Delete(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).Freeze(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Freeze(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.Freeze(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.Freeze(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.GetWIPMsgs(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.GetWIPMsgs(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).Load(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Load(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.Load(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus Load(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.Load(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_LoadESigDetails_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.LoadESigDetails, (SPCChartDefGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_LoadESigDetails_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.LoadESigDetails(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_LoadESigDetails_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.LoadESigDetails(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).New(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus New(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.New(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus New(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.New(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).NewCopy(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus NewCopy(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.NewCopy(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.NewCopy(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).SaveAs(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus SaveAs(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.SaveAs(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.SaveAs(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).UnFreeze(this._UserProfile, sPCChartDefGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(sPCChartDefGroupMaint, SPCChartDefGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sPCChartDefGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SPCChartDefGroupMaint) null, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(SPCChartDefGroupMaint sPCChartDefGroupMaint)
    {
      return this.UnFreeze(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.UnFreeze(sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_LoadESigDetails_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sPCChartDefGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SPCChartDefGroupMaint) sPCChartDefGroupMaint, (SPCChartDefGroupMaint_Parameters) parameters, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      try
      {
        SPCChartDefGroupMaintMethod[] methods = new SPCChartDefGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISPCChartDefGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SPCChartDefGroupMaint cdo,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      try
      {
        return ((ISPCChartDefGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SPCChartDefGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SPCChartDefGroupMaint) cdo, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.GetEnvironment((SPCChartDefGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SPCChartDefGroupMaint cdo,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      result = (SPCChartDefGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(cdo, SPCChartDefGroupMaintMethods.ExecuteTransaction, (SPCChartDefGroupMaint_Parameters) null));
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
        SPCChartDefGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SPCChartDefGroupMaint) cdo, (SPCChartDefGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SPCChartDefGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SPCChartDefGroupMaint_Request) null, out SPCChartDefGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result)
    {
      return this.ExecuteTransaction((SPCChartDefGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SPCChartDefGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SPCChartDefGroupMaintMethod(cdo, SPCChartDefGroupMaintMethods.AddDataTransaction, (SPCChartDefGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((SPCChartDefGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
