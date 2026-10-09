import { HttpStatus, Injectable } from '@nestjs/common';
import { GameFeatureApiService } from 'src/basic/game-feature-api.service';
import { ApplicationContextService } from 'src/basic/services/application-context.service';
import { FinalPreparationPurchaseRequest } from './request/final-preparation-purchase.request';
import { FinalPreparationUseItemRequest } from './request/final-preparation-use-item.request';
import { FinalPreparationCurrentRequest } from './request/final-preparation-current.request';
import { ApiErrorMappingRule, ApiErrorStatusMap, ErrorUtils, } from 'src/basic/error/error.utils';
import { ErrorCode } from 'src/basic/error/error-code.enum';

const FINAL_PREPARATION_API_ERROR_STATUS_MAP: ApiErrorStatusMap = {
  [HttpStatus.NOT_FOUND]: {
    messageCode: ErrorCode.PREPARATION_UNAVAILABLE,
    message: 'Final preparation is not available right now.',
  },
  [HttpStatus.CONFLICT]: {
    messageCode: ErrorCode.PREPARATION_UNAVAILABLE,
    message: 'Final preparation is not available right now.',
  },
};

const FINAL_PREPARATION_API_ERROR_FALLBACK: ApiErrorMappingRule = {
  messageCode: ErrorCode.PREPARATION_UNAVAILABLE,
  message: 'Unable to load the final preparation right now.',
};

@Injectable()
export class FinalPreparationService {
  constructor(
    private readonly context: ApplicationContextService,
    private readonly game: GameFeatureApiService,
  ) { }

  async getRewards() {
    const teamId = this.context.getCurrentTeamId();

    try {
      const rewards = await this.game.rewards(teamId);

      return rewards;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async getInventory() {
    const teamId = this.context.getCurrentTeamId();

    try {
      const inventory = await this.game.inventory(teamId);

      return inventory;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async getPowerUps() {
    const language = this.context.language;

    try {
      const powerUps = await this.game.powerUps(language);

      return powerUps;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async getStrategies() {
    const language = this.context.language;

    try {
      const strategies = await this.game.strategies(language);

      return strategies;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async getFinalStage() {
    const teamId = this.context.getCurrentTeamId();

    try {
      const finalStage = await this.game.finalStage(teamId);

      return finalStage;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async postPurchases(request: FinalPreparationPurchaseRequest) {
    const teamId = this.context.getCurrentTeamId();

    try {
      const postPurchase = await this.game.purchases(teamId, request);

      return postPurchase;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async postUseItem(request: FinalPreparationUseItemRequest) {
    const teamId = this.context.getCurrentTeamId();

    try {
      const postUseItem = await this.game.useItem(teamId, request);

      return postUseItem;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }

  async savePreparation(request: FinalPreparationCurrentRequest) {
    const teamId = this.context.getCurrentTeamId();

    try {
      const putCurrent = await this.game.savePreparation(teamId, request);

      return putCurrent;
    } catch (error) {
      ErrorUtils.mapGameApiError(
        error,
        FINAL_PREPARATION_API_ERROR_STATUS_MAP,
        FINAL_PREPARATION_API_ERROR_FALLBACK,
      );
    }
  }
}