// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SellReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SellReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public SellReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISellReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).Delete(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.Delete(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.Delete(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.Freeze(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.Freeze(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.GetWIPMsgs(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).Load(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Load(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.Load(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.Load(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_LoadESigDetails_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.LoadESigDetails, (SellReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SellReasonGroupMaint) null, (SellReasonGroupMaint_LoadESigDetails_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.LoadESigDetails(sellReasonGroupMaint, (SellReasonGroupMaint_LoadESigDetails_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(sellReasonGroupMaint, (SellReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).New(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus New(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.New(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.New(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.NewCopy(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.NewCopy(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.SaveAs(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.SaveAs(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, sellReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(sellReasonGroupMaint, SellReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sellReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SellReasonGroupMaint) null, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(SellReasonGroupMaint sellReasonGroupMaint)
    {
      return this.UnFreeze(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.UnFreeze(sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_LoadESigDetails_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sellReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SellReasonGroupMaint) sellReasonGroupMaint, (SellReasonGroupMaint_Parameters) parameters, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      try
      {
        SellReasonGroupMaintMethod[] methods = new SellReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISellReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SellReasonGroupMaint cdo,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      try
      {
        return ((ISellReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SellReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SellReasonGroupMaint) cdo, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((SellReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SellReasonGroupMaint cdo,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      result = (SellReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SellReasonGroupMaintMethod(cdo, SellReasonGroupMaintMethods.ExecuteTransaction, (SellReasonGroupMaint_Parameters) null));
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
        SellReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SellReasonGroupMaint) cdo, (SellReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SellReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SellReasonGroupMaint_Request) null, out SellReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((SellReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SellReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SellReasonGroupMaintMethod(cdo, SellReasonGroupMaintMethods.AddDataTransaction, (SellReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((SellReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
