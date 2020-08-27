// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NumberingRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NumberingRuleMaintService : NamedDataObjectMaintBase
  {
    public NumberingRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INumberingRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).Delete(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Delete(NumberingRuleMaint numberingRuleMaint)
    {
      return this.Delete(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Delete(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.Delete(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).Freeze(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Freeze(NumberingRuleMaint numberingRuleMaint)
    {
      return this.Freeze(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.Freeze(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NumberingRuleMaint numberingRuleMaint)
    {
      return this.GetWIPMsgs(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.GetWIPMsgs(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).Load(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Load(NumberingRuleMaint numberingRuleMaint)
    {
      return this.Load(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus Load(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.Load(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_LoadESigDetails_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.LoadESigDetails, (NumberingRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NumberingRuleMaint) null, (NumberingRuleMaint_LoadESigDetails_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NumberingRuleMaint numberingRuleMaint)
    {
      return this.LoadESigDetails(numberingRuleMaint, (NumberingRuleMaint_LoadESigDetails_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.LoadESigDetails(numberingRuleMaint, (NumberingRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).New(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus New(NumberingRuleMaint numberingRuleMaint)
    {
      return this.New(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus New(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.New(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).NewCopy(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus NewCopy(NumberingRuleMaint numberingRuleMaint)
    {
      return this.NewCopy(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.NewCopy(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus ResetLastAssignedSequence(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ResetLastAssignedSequence), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).ResetLastAssignedSequence(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.ResetLastAssignedSequence, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResetLastAssignedSequence), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResetLastAssignedSequence()
    {
      return this.ResetLastAssignedSequence((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus ResetLastAssignedSequence(NumberingRuleMaint numberingRuleMaint)
    {
      return this.ResetLastAssignedSequence(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus ResetLastAssignedSequence(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.ResetLastAssignedSequence(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).SaveAs(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus SaveAs(NumberingRuleMaint numberingRuleMaint)
    {
      return this.SaveAs(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.SaveAs(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).UnFreeze(this._UserProfile, numberingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(numberingRuleMaint, NumberingRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) numberingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NumberingRuleMaint) null, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(NumberingRuleMaint numberingRuleMaint)
    {
      return this.UnFreeze(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.UnFreeze(numberingRuleMaint, (NumberingRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_LoadESigDetails_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject numberingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NumberingRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NumberingRuleMaint) numberingRuleMaint, (NumberingRuleMaint_Parameters) parameters, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      try
      {
        NumberingRuleMaintMethod[] methods = new NumberingRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INumberingRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NumberingRuleMaint cdo,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      try
      {
        return ((INumberingRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NumberingRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NumberingRuleMaint) cdo, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.GetEnvironment((NumberingRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NumberingRuleMaint cdo,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      result = (NumberingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INumberingRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NumberingRuleMaintMethod(cdo, NumberingRuleMaintMethods.ExecuteTransaction, (NumberingRuleMaint_Parameters) null));
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
        NumberingRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NumberingRuleMaint) cdo, (NumberingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NumberingRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NumberingRuleMaint_Request) null, out NumberingRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result)
    {
      return this.ExecuteTransaction((NumberingRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NumberingRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NumberingRuleMaintMethod(cdo, NumberingRuleMaintMethods.AddDataTransaction, (NumberingRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((NumberingRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
