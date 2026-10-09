import { ApiProperty } from '@nestjs/swagger';
import { ArrayMinSize, IsArray, IsString } from 'class-validator';

export class FinalPreparationCurrentRequest {
  @ApiProperty()
  @IsString()
  strategy: string;

  @ApiProperty({ type: [String] })
  @IsArray()
  @ArrayMinSize(3)
  @IsString({ each: true })
  activeHeroIds: string[];
}